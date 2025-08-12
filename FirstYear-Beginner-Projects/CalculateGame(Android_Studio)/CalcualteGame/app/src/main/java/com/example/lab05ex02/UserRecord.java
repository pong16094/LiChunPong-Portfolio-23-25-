package com.example.lab05ex02;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class UserRecord extends AppCompatActivity {

    SQLiteDatabase db;
    ListView lvrc;
    String[] data;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_record);
        lvrc = findViewById(R.id.lvrc);
try {
    db = SQLiteDatabase.openDatabase("/data/data/com.example.lab05ex02/GamesLog",
            null, SQLiteDatabase.OPEN_READONLY);

    Cursor cursor = db.rawQuery("SELECT * FROM GamesLog", null);
    data = new String[cursor.getCount()];
    String word = "";
    int index = 0;

    while (cursor.moveToNext()) {
        word = "";
        word += cursor.getString(1) + ", ";
        word += cursor.getString(2) + ", ";
        word += String.valueOf(cursor.getInt(3)) + "sec ";
        word += String.valueOf(cursor.getInt(4)) + "correct ";
        data[index] = word;
        index++;
    }
    ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, data);
    lvrc.setAdapter(adapter);
}
catch (Exception e){

}

    }


}