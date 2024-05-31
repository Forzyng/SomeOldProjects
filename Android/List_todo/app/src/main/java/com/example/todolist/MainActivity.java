package com.example.todolist;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;

import com.example.todolist.ToDo.AddTask;
import com.example.todolist.ToDo.OnDialogCloseListner;
import com.example.todolist.ToDo.RecyclerViewTouchHelper;
import com.example.todolist.ToDo.SqlDB_Helper;
import com.example.todolist.ToDo.ToDoAdapter;
import com.example.todolist.ToDo.ToDoTask;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class MainActivity extends AppCompatActivity implements OnDialogCloseListner {

    private RecyclerView recyclerView;
    private FloatingActionButton floatingActionButton;
    private SqlDB_Helper sqlDB_helper;
    private List<ToDoTask> mainList;
    private ToDoAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        recyclerView = findViewById(R.id.my_list);
        floatingActionButton = findViewById(R.id.add_btn);
        sqlDB_helper = new SqlDB_Helper(MainActivity.this);
        mainList = new ArrayList<>();
        adapter = new ToDoAdapter(sqlDB_helper , MainActivity.this);

        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setAdapter(adapter);

        mainList = sqlDB_helper.getAllTasks();
        Collections.reverse(mainList);
        adapter.setTasks(mainList);

        floatingActionButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                AddTask.newInstance().show(getSupportFragmentManager() , AddTask.TAG);
            }
        });
        ItemTouchHelper itemTouchHelper = new ItemTouchHelper(new RecyclerViewTouchHelper(adapter));
        itemTouchHelper.attachToRecyclerView(recyclerView);
    }

    @Override
    public void onDialogClose(DialogInterface dialogInterface) {
        mainList = sqlDB_helper.getAllTasks();
        Collections.reverse(mainList);
        adapter.setTasks(mainList);
        adapter.notifyDataSetChanged();
    }
}