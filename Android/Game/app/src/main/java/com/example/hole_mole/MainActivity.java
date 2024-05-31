package com.example.hole_mole;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;


public class MainActivity extends AppCompatActivity {

    String [] arrCountriesNames = {"Ukraine", "Poland", "Germany"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.begin_adapter);

        ListView lst = findViewById(R.id.lstCountries);

        ArrayAdapter<String> adapterLst = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, arrCountriesNames);

        lst.setAdapter(adapterLst);
    }

}