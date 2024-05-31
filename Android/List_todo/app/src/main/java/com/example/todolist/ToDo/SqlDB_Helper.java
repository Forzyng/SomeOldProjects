package com.example.todolist.ToDo;

import android.annotation.SuppressLint;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class SqlDB_Helper extends SQLiteOpenHelper {

    private SQLiteDatabase sqLiteDatabase;

    private static  final String DATABASE_NAME = "todo_db";
    private static  final String TABLE_NAME = "todo_tbl";
    private static  final String ID_COL = "id";
    private static  final String NAME_COL = "name";
    private static  final String STATUS_COL = "status";

    public SqlDB_Helper(@Nullable Context context ) {
        super(context, DATABASE_NAME, null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        String query = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ("
                + ID_COL + " INTEGER PRIMARY KEY AUTOINCREMENT, "
                + NAME_COL + " TEXT,"
                + STATUS_COL + " INTEGER" + ")";

        sqLiteDatabase.execSQL(query);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {
        String sql = "DROP TABLE IF EXISTS " + TABLE_NAME;
        sqLiteDatabase.execSQL(sql);
        onCreate(sqLiteDatabase);
    }

    public void addTask(ToDoTask task){
        sqLiteDatabase = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(NAME_COL , task.getName());
        values.put(STATUS_COL , 0);
        sqLiteDatabase.insert(TABLE_NAME , null , values);
        sqLiteDatabase.close();
    }

    public void updateTask(int id , String task){
        sqLiteDatabase = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(NAME_COL , task);
        sqLiteDatabase.update(TABLE_NAME , values , "ID=?" , new String[]{String.valueOf(id)});
    }

    public void updateStatus(int id , int status){
        sqLiteDatabase = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(STATUS_COL , status);
        sqLiteDatabase.update(TABLE_NAME , values , "ID=?" , new String[]{String.valueOf(id)});
    }

    public void deleteTask(int id ){
        sqLiteDatabase = this.getWritableDatabase();
        sqLiteDatabase.delete(TABLE_NAME , "ID=?" , new String[]{String.valueOf(id)});
    }


    public List<ToDoTask> getAllTasks(){

        // on below line we are creating a
        // database for reading our database.
        sqLiteDatabase = this.getReadableDatabase();

        // on below line we are creating a cursor with query to read data from database.
        Cursor cursor = sqLiteDatabase.rawQuery("SELECT * FROM " + TABLE_NAME, null);

        // on below line we are creating a new array list.
        List<ToDoTask> TodoList = new ArrayList<>();

        // moving our cursor to first position.
        if (cursor.moveToFirst()) {
            do {
               /* ToDoTask task = new ToDoTask();
                task.setId(cursor.getInt(cursor.getColumnIndex(ID_COL)));
                task.setName(cursor.getString(cursor.getColumnIndex(NAME_COL)));
                task.setStatus(cursor.getInt(cursor.getColumnIndex(STATUS_COL)));*/
                // on below line we are adding the data from cursor to our array list.
                TodoList.add(new ToDoTask(cursor.getInt(0),
                        cursor.getString(1),
                        cursor.getInt(2)));
            } while (cursor.moveToNext());
            // moving our cursor to next.
        }
        // at last closing our cursor
        // and returning our array list.
        cursor.close();
        return TodoList;
    }
}
