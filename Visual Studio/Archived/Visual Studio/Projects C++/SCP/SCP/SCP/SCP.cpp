
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <stdio.h>
#include <string>

HANDLE hD;

bool DiskOpen(char* vol)
{
    char szDrive[10];
    sprintf(szDrive, "\\\\.\\%c:", vol[0]);
    hD = CreateFile(
        szDrive,
        GENERIC_READ | GENERIC_WRITE,
        FILE_SHARE_READ | FILE_SHARE_WRITE,
        NULL,
        OPEN_EXISTING,
        0,
        NULL);
    return hD != INVALID_HANDLE_VALUE;
}

void DiskClose()
{
    if (hD != INVALID_HANDLE_VALUE)
        CloseHandle(hD);
}

bool ReadSector(DWORD sector, char* Buffer, int sectorSize)
{
    DWORD read = 0;

    if (SetFilePointer(hD, sector, NULL, FILE_BEGIN) == INVALID_SET_FILE_POINTER)
        return false;

    if (!ReadFile(hD, Buffer, sectorSize, &read, NULL))
        return false;
    return true;
}

bool WriteSector(DWORD sector, char* Buffer, int sectorSize)
{
    DWORD wrote = 0;

    if (SetFilePointer(hD, sector, NULL, FILE_BEGIN) == INVALID_SET_FILE_POINTER)
        return false;

    if (!WriteFile(hD, Buffer, sectorSize, &wrote, NULL))
        return false;

    return true;
}

void __fastcall Spoof()
{
    //проверяем не пусты ли необходимые поля
   // if ((ComboBox1->Text != "") && (Edit1->Text != ""))
   // {
        DWORD newSerial =""; //ZN1K07HW
        const int max_pbsi = 3;
        //определяем структуру для сигнатуры загрузочной области
        struct partial_boot_sector_info
        {
            LPSTR Fs; // название файловой системы
            DWORD FsOffs; // смещение системного имени в загрузочной области
            DWORD SerialOffs; // смещение серийного номера в загрузочной области
        };
        //описываем часто используемые сигнатуры
        partial_boot_sector_info pbsi[max_pbsi] =
        {
         {(LPSTR)"FAT32", 0x52, 0x43},
         {(LPSTR)"FAT",   0x36, 0x27},
         {(LPSTR)"NTFS",  0x03, 0x48}
        };
        //инициализируем необходимые переменные
        TCHAR Drive[12] = { 0 };
        char Sector[512];
        DWORD i;
        sprintf(Drive, "%s:\\", ComboBox1->Text);
        //открываем диск
        if (!DiskOpen(Drive))
        {//если ошибка оповещаем пользователя и выходим из процелуры
            std::cout << "Невозможно открыть диск!";
            return;
        }

        // читаем загрузочную область
        if (!ReadSector(0, Sector, 512))
        {
            std::cout <<  "Невозможно считать данные";
            return;
        }

        // посик сигнатуры загрузочной области
        for (i = 0; i = max_pbsi;)
        {
            std::cout << "Невозможно сменить номер для этой файловой системы!";
            return;
        }

        // меняем номер
        *(PDWORD)(Sector + pbsi[i].SerialOffs) = newSerial;

        // записываем в загрузочную область
        if (!WriteSector(0, Sector, 512))
        {
            std::cout <<  "Невозможно записать на диск!", "Ошибка";
            return;
        }
        DiskClose();
        std::cout << "Серийный номер успешно изменен! Необходимо перезагрзить компьютер.";
   // }
  //  else
  //     std::cout << "Не указан диск или серийный номер! ";
}


void main()
{

}

