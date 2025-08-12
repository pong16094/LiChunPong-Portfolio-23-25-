package com.example.lab05ex02;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class GameActivity extends AppCompatActivity {

    private static final int REQUEST_CODE = 4501;
    private int startTime;
    private String[] operators = {"+", "-", "*", "/"};
    private int Num1, Num2, Answer, qstNum, correct;
    private TextView tvquestion, tvtime, tvqsno, tvcheck, tvans;
    private EditText etans;
    private Handler handler;
    private Runnable runnable;
    private Button btnext;
    private boolean clicked = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game);

        tvquestion = findViewById(R.id.tvquestion);
        tvqsno = findViewById(R.id.tvqsno);
        tvtime = findViewById(R.id.tvtime);
        tvcheck = findViewById(R.id.tvcheck);
        tvans = findViewById(R.id.tvans);
        etans = findViewById(R.id.etans);
        btnext = findViewById(R.id.btnext);
        Intent intent = getIntent();

        qstNum = intent.getIntExtra("Question", 0);
        qstNum++;
        startTime = intent.getIntExtra("Time",0);
        correct = intent.getIntExtra("correctNum",0);
        if(qstNum>10){
            Intent i = new Intent(this, Finish.class);
            i.putExtra("correct", correct);
            i.putExtra("Time", startTime);
            startActivityForResult(i, REQUEST_CODE);
            this.finish();
        }

        tvqsno.setText("Question " + qstNum);

        Handler handler = new Handler();
        runnable = new Runnable() {
            @Override
            public void run() {
                updateTimer();
                handler.postDelayed(this, 1000); // Update every second
            }
        };

        handler.postDelayed(runnable, 1000);
        int random = (int) (Math.random() * 4);
        GenQuestion(operators[random]);
    }

    private void updateTimer() {
        startTime++;
        tvtime.setText("Time: " + startTime + " sec");
    }

    public void onFinish(View view) {
        finish();
    }

    public void GenQuestion(String operators) {
        Num1 = (int) (Math.random() * 100 + 1);
        Num2 = (int) (Math.random() * 100 + 1);
        if (operators == "/") {
            biggerNum();
            if (Num1 % Num2 > 0) {
                GenQuestion(operators);
                return;
            }
            Answer = Num1 /Num2;
            setAnswer(operators);
            return;
        } else {
            switch (operators) {
                case "+":
                    Answer = Num1 +Num2;
                    setAnswer(operators);
                    break;

                case "-":
                    biggerNum();
                    if (Num1 - Num2 < 0) {
                        GenQuestion(operators);
                        return;
                    }
                    Answer = Num1 - Num2;
                    setAnswer(operators);
                    break;

                case "*":
                    Answer = Num1* Num2;
                    setAnswer(operators);
                    break;
                default:
                    throw new IllegalArgumentException("Invalid operator");
            }
        }
        return;

    }

    public void biggerNum() {
        if (Num1 < Num2) {
            int temp = Num1;
            Num1 = Num2;
            Num2 = temp;
        }
        return;
    }

    public void setAnswer(String operators) {
        tvquestion.setText(Num1 + operators + Num2 + " = ?");
    }

    public void CheckAns(View view) {
        if (!clicked) {

            if (etans.getText().toString().isEmpty()) {
                return;
            }
            if (Integer.parseInt(etans.getText().toString()) == Answer) {
                tvcheck.setText("CORRECT!");
                correct++;
            } else {
                tvcheck.setText("WRONG!");
                tvans.setText("Answer is " + Answer + "!");
            }
            btnext.setVisibility(view.VISIBLE);
            clicked=true;
        }
    }

    public void NextQuestion(View view) {
        Intent i = new Intent(this, this.getClass());
        i.putExtra("Question", qstNum);
        i.putExtra("Time", startTime);
        i.putExtra("correctNum", correct);
        startActivityForResult(i, REQUEST_CODE);
        this.finish();
    }
}