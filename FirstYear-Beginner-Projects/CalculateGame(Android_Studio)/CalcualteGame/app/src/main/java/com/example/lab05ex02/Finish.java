package com.example.lab05ex02;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import java.sql.Timestamp;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

public class Finish extends AppCompatActivity {

    SQLiteDatabase db;
    private static final int REQUEST_CODE = 4501;
    private TextView tvcorrect,tvusetime;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_finish);
        tvcorrect = findViewById(R.id.tvcorrect);
        tvusetime = findViewById(R.id.tvusetime);

        Intent intent = getIntent();
        int correct = intent.getIntExtra("correct", 0);
        int time = intent.getIntExtra("Time", 0);
        int wrong = 10 - correct;
        tvcorrect.setText("Correct: " + correct + ",Wrong " + wrong + "!");
        tvusetime.setText("Time: " + time + " sec");

//make database
        String sql;
        try {
            // Create a database if it does not exist
            db = SQLiteDatabase.openDatabase("/data/data/com.example.lab05ex02/GamesLog",
                    null, SQLiteDatabase.CREATE_IF_NECESSARY);

            sql="CREATE TABLE IF NOT EXISTS GamesLog  (" +
                    "gameID INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "playDate BLOB not null," +
                    "playTime BLOB not null," +
                    "duration INTEGER not null," +
                    "correctCount INTEGER not null" +
                    ")";
            db.execSQL(sql);

            int gameid = 0;
            Cursor c = db.rawQuery("SELECT max(gameID) FROM GamesLog",null);
            if (c.moveToFirst()) {
                gameid = c.getInt(0);
                gameid++;
            } else {
                // Handle the case where the result is empty
                gameid=1;
            }
            Date currentDate = new Date();
            SimpleDateFormat dateFormat = new SimpleDateFormat("dd-MM-yyyy", Locale.getDefault());
            SimpleDateFormat timeFormat = new SimpleDateFormat("HH:mm", Locale.getDefault());
            String playDate = dateFormat.format(currentDate);
            String playTime = timeFormat.format(currentDate);

            db.execSQL("INSERT INTO GamesLog(gameID, playDate, playTime, duration, correctCount) VALUES "
                    + "(" + gameid + ", '" + playDate + "', '" + playTime + "', " + time + ", " + correct + ");");

        }
        catch (SQLiteException e) {
            //Toast.makeText(this, e.getMessage(), Long).show();
        }

    }

    public void PlayAgain(View view) {
        Intent i = new Intent(this, GameActivity.class);
        startActivityForResult(i, REQUEST_CODE);
        this.finish();
    }

    public void Back(View view) {
        Intent i = new Intent(this, MainActivity.class);
        startActivityForResult(i, REQUEST_CODE);
        this.finish();
    }
}