import java.util.Scanner;

public class ReversiGame {
    public static void main(String[] arg) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Please enter the board size (4 or above and even number)");
        int BoardSize = sc.nextInt();

        while (true) { // check the BoardSize is it =4/6/10 if yes
            if (BoardSize == 4) {
                break;
            } else {
                if (BoardSize == 6) {
                    break;
                } else {
                    if (BoardSize == 10) {
                        break;
                    }
                }
            }

            System.out.print("Please enter the board size (4 or above and even number)");
            BoardSize = sc.nextInt();
        }

        int[][] MyArray = new int[BoardSize][BoardSize]; // creating board

        int SetRow = (BoardSize / 2) - 1, SetColumn = SetRow; // set the middle chess
        MyArray[SetRow][SetColumn] = 1;
        MyArray[SetRow][(SetColumn + 1)] = 2;
        SetRow++; // next row two chess
        MyArray[SetRow][SetColumn] = 2;
        MyArray[SetRow][(SetColumn + 1)] = 1;
        PrintMyArray(MyArray);
        int Player = 1;
        int ChangePlayer = -1;
        System.out.print(MyArray.length);
        while (true) {
            boolean YesNo = false;
            int CountZero = 0, CountPlayer = 0;
            Check: {
                for (int RLoop = 0; RLoop < MyArray.length; RLoop++) {
                    for (int CLoop = 0; CLoop < MyArray[RLoop].length; CLoop++) {
                        if (CountZero == 1 && CountPlayer == 1) { // if the board have area to put chess or atleast have
                            break Check;
                        }
                        if (MyArray[RLoop][CLoop] == 0) {
                            CountZero++;
                        } else {
                            if (MyArray[RLoop][CLoop] == Player) {
                                CountPlayer++;
                            }
                        }
                    }
                }
            }
            if (CountZero == 0 || CountPlayer == 0) {// if no place or no player chess on board will end the game
                if (CountPlayer == 0) {
                    System.out.println("'" + Player + "' has no piece left.");
                    System.out.println("Game Finishes.");
                    CountChess(MyArray);
                    break;
                }
                if (CountZero == 0) {
                    CountChess(MyArray);
                    break;
                }
            } else {
                while (!YesNo) {
                    System.out.print("Plase enter the position of '" + Player + "' (row col):"); // let player put chess
                    int Row = sc.nextInt();
                    int Column = sc.nextInt();
                    YesNo = CheckInput(Row, Column, BoardSize, Player, MyArray);// check the number are over the the
                                                                                // board?
                }
                PrintMyArray(MyArray);
            }
            ChangePlayer *= -1;
            Player += ChangePlayer;
        }

    }

    public static void PrintMyArray(int[][] arr) { // Print the array
        for (int Row = 0; Row < arr.length; Row++) {
            System.out.printf("%3d |", Row);
            for (int Column = 0; Column < arr[Row].length; Column++) {
                System.out.printf("%3d", arr[Row][Column]);
            }
            System.out.println();
        }
        System.out.print("    +"); // print the format
        for (int Loop = 0; Loop < arr.length; Loop++) {
            System.out.print("---");
        }
        System.out.println(" ");
        System.out.print("     ");
        for (int Loop = 0; Loop < arr.length; Loop++) {
            System.out.printf("%3d", Loop);
        }
        System.out.println(" ");
    }

    public static boolean CheckInput(int Row, int Column, int BoardSize, int Player, int[][] arr) { // Check the input
                                                                                                    // number are -
        if (Row < 0 || Row >= BoardSize) {
            System.out.println("Error - input numbers should be 0 to " + (BoardSize - 1));
            return false;
        } else {
            if (Column < 0 || Column >= BoardSize) {
                System.out.println("Error - input numbers should be 0 to " + (BoardSize - 1));
                return false;
            } else {
                if (arr[Row][Column] != 0) { // check it is null(=0)
                    return false;
                } else {
                    return (CheckCanItPut(Row, Column, Player, arr, BoardSize));

                }
            }
        }
    }

    public static boolean CheckCanItPut(int Row, int Column, int Player, int[][] arr, int BoardSize) { // check put
                                                                                                       // chess
        int Yes = 0;
        if (Row != (arr.length - 1)) {
            for (int RowLoop = Row + 1; RowLoop < arr.length; RowLoop++) { // Check the bottom part
                if (arr[RowLoop][Column] == 0 || arr[RowLoop][Column] == Player) {// arr=0 or player
                    if (RowLoop == Row + 1 || arr[RowLoop][Column] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversPartRightBottem(Row, Column, RowLoop, Column, Player, arr);
                        break;
                    }
                }
            }
        }
        if (Column != (arr.length - 1)) {
            for (int CLoop = Column + 1; CLoop < arr[Row].length; CLoop++) { // Check the Right part
                if (arr[Row][CLoop] == 0 || arr[Row][CLoop] == Player) {
                    if (CLoop == Column + 1 || arr[Row][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversPartRightBottem(Row, Column, Row, CLoop, Player, arr);
                        CLoop = Column + 1;
                        break;
                    }
                }
            }
        }
        if (Column != (arr.length - 1) && Row != (arr.length - 1)) { // right bottem part
            int CLoop = Column + 1;
            for (int RowLoop = Row + 1; RowLoop < arr.length; RowLoop++) {
                if (arr[RowLoop][CLoop] == 0 || arr[RowLoop][CLoop] == Player) {
                    if (CLoop == Column + 1 || arr[RowLoop][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversPartRightBottem(Row, Column, RowLoop, CLoop, Player, arr);
                        CLoop = Column + 1;
                        break;
                    }
                }
                if (CLoop < (arr.length - 1)) {
                    CLoop++;
                } else {
                    break;
                }
            }
        }

        if (Row != 0) { // up
            for (int RowLoop = Row - 1; RowLoop >= 0; RowLoop--) {
                if (arr[RowLoop][Column] == 0 || arr[RowLoop][Column] == Player) {
                    if (RowLoop == Row - 1 || arr[RowLoop][Column] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversUp(Row, Column, RowLoop, Column, Player, arr);
                        break;
                    }
                }
            }
        }
        if (Column != (arr.length - 1) && Row != 0) { // right up part
            int CLoop = Column + 1;
            for (int RowLoop = Row - 1; RowLoop > 0; RowLoop--) {
                if (arr[RowLoop][CLoop] == 0 || arr[RowLoop][CLoop] == Player) {
                    if (CLoop == Column + 1 || arr[RowLoop][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversUp(Row, Column, RowLoop, CLoop, Player, arr);
                        CLoop = Column + 1;
                        break;
                    }
                }
                if (CLoop < (arr.length - 1)) {
                    CLoop++;
                } else {
                    break;
                }
            }
        }
        if (Column != 0 && Row != 0) { // left up
            int CLoop = Column - 1;
            for (int RowLoop = Row - 1; Row >= 0; RowLoop--) {
                if (arr[RowLoop][CLoop] == 0 || arr[RowLoop][CLoop] == Player) {// have bug
                    if (CLoop == Column - 1 || arr[RowLoop][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversUp(Row, Column, RowLoop, CLoop, Player, arr);
                        break;
                    }
                }
                if (CLoop > 0) {
                    CLoop--;
                } else {
                    break;
                }
                if (RowLoop == 0)
                    break;
            }
        }
        if (Column != 0) {// left
            for (int CLoop = Column - 1; CLoop >= 0; CLoop--) {
                if (arr[Row][CLoop] == Player || arr[Row][CLoop] == 0) {
                    if (CLoop == Column - 1 || arr[Row][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversLeft(Row, Column, Row, CLoop, Player, arr);
                        break;
                    }
                }
            }
        }
        if (Row != (arr.length - 1) && Column != 0) { // right down part
            int RLoop = Row + 1;
            for (int CLoop = Column - 1; CLoop >= 0; CLoop--) {
                if (arr[RLoop][CLoop] == 0 || arr[RLoop][CLoop] == Player) {
                    if (RLoop == Row + 1 || arr[RLoop][CLoop] == 0) {
                        break;
                    } else {
                        Yes += 1;
                        ReversLeft(Row, Column, RLoop, CLoop, Player, arr);
                        break;
                    }
                }
                if (RLoop < (arr.length - 1)) {
                    RLoop++;
                } else {
                    break;
                }
            }
        }
        if (Yes == 0) {
            return false;
        } else {
            return true;
        }
    }

    public static void ReversPartRightBottem(int PlayerSetRo, int PlayerSetCo, int AftCheckRo, //
            int AftCheckCo, int Player, int[][] arr) {
        int CLoop = PlayerSetCo;
        for (int RowLoop = PlayerSetRo; RowLoop < arr.length; RowLoop++) {
            if (PlayerSetCo < AftCheckCo && PlayerSetRo < AftCheckRo) {// right down
                if (CLoop < AftCheckCo) {
                    arr[RowLoop][CLoop] = Player;
                    CLoop++;
                } else {
                    return;
                }
            }

            if (PlayerSetRo < AftCheckRo && PlayerSetCo == AftCheckCo) { // down
                if (RowLoop < AftCheckRo) {
                    arr[RowLoop][PlayerSetCo] = Player;
                } else {
                    return;
                }
            }

            if (PlayerSetRo == AftCheckRo && PlayerSetCo < AftCheckCo) { // right
                while (CLoop < AftCheckCo) {
                    arr[RowLoop][CLoop] = Player;
                    CLoop++;
                }
                return;
            }
        }

    }

    public static void ReversUp(int PlayerSetRo, int PlayerSetCo, int AftCheckRo, int AftCheckCo, int Player,
            int[][] arr) {
        int CLoop = PlayerSetCo;
        for (int RowLoop = PlayerSetRo; RowLoop > 0; RowLoop--) {
            if (PlayerSetRo > AftCheckRo && PlayerSetCo == AftCheckCo) {// Up
                if (RowLoop > AftCheckRo) {
                    arr[RowLoop][PlayerSetCo] = Player;
                } else {
                    return;
                }
            }
            if (PlayerSetCo < AftCheckCo && PlayerSetRo > AftCheckRo) {// right up
                if (RowLoop > AftCheckRo) {
                    arr[RowLoop][CLoop] = Player;
                    CLoop++;
                } else {
                    return;
                }
            }
            if (PlayerSetCo > AftCheckCo && PlayerSetRo > AftCheckRo) {// left up
                if (RowLoop > AftCheckRo) {
                    arr[RowLoop][CLoop] = Player;
                    CLoop--;
                } else {
                    return;
                }
            }
        }
    }

    public static void ReversLeft(int PlayerSetRo, int PlayerSetCo, int AftCheckRo, int AftCheckCo, int Player,
            int[][] arr) {
        int RLoop = PlayerSetRo;
        for (int CLoop = PlayerSetCo; CLoop > 0; CLoop--) {
            if (PlayerSetRo == AftCheckRo && PlayerSetCo > AftCheckCo) {// revers left
                if (CLoop > AftCheckCo) {
                    arr[PlayerSetRo][CLoop] = Player;
                } else {
                    return;
                }
            }
            if (PlayerSetRo < AftCheckRo && PlayerSetCo > AftCheckCo) {// left bottom
                if (CLoop > AftCheckCo) {
                    arr[RLoop][CLoop] = Player;
                    RLoop++;
                } else {
                    return;
                }
            }
        }
    }

    public static void CountChess(int[][] arr) {// last part count chess
        int P1 = 0;
        int P2 = 0;
        for (int RLoop = 0; RLoop < arr.length; RLoop++) {
            for (int CLoop = 0; CLoop < arr[RLoop].length; CLoop++) {
                if (arr[RLoop][CLoop] == 1) {
                    P1++;
                }
                if (arr[RLoop][CLoop] == 2) {
                    P2++;
                }
            }
        }
        System.out.println("   '1' - " + P1);
        System.out.println("   '2' - " + P2);
        if (P2 > P1) {
            System.out.print("White wins.");
        }
        if (P1 > P2) {
            System.out.print("Black wins.");
        }
        if (P1 == P2) {
            System.out.print("draw.");
        }
    }
}