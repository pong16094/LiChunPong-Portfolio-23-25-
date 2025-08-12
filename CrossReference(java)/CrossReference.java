/**
Cross Reference Map
*/
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class CrossReference extends Tokenizer{//java keyword tree words
	public static String[] wordList = {"abstract", "assert", "boolean", "break", "byte", "case", "catch", "char", "class", "continue",
    "default", "do", "double", "else", "enum", "extends", "final", "finally", "float", "for",
    "package", "if", "implements", "import", "instanceof", "int", "interface", "long", "native", "new",
    "synchronized", "this", "private", "protected", "public", "return", "short", "static", "strictfp", "super", "switch",
    "throw", "throws", "transient", "try", "void", "volatile", "while",
    "const", "goto", "true", "false", "null"};
    public static void main(String [] args) {
		ListBst list = new ListBst();//main word list
		ListBst keyword = new ListBst();//java keyword tree
		String comparaWord =null;//for compare word
		for(int i = 0 ; i<wordList.length;i++){//make the java keyword tree
			keyword.addNode(wordList[i]);
		}
		System.out.println("----------------------------------");
		System.out.println("Program created by Li Chun Pong.\n");
		try{
			Scanner fin = new Scanner(new File(args[0]));
			String line;//stock every line of the file
			int lineNum = 1;
			System.out.println("SOURCE FILE:"+args[0]);
			while (fin.hasNextLine()) {//read file
				line = fin.nextLine();
				System.out.printf("%04d | %s%n",lineNum,line);
				line = line.trim();
				String []array =tokenizer(line);//each word store in to the array
				for(int i=0; i<array.length;i++){
					if(array[i]=="")continue;
					comparaWord=keyword.search(array[i]);//check the word in tree?
					if(comparaWord==null){
						list.addListNode(array[i],lineNum);//if no make a node of it
					}
					
				}
				lineNum++;//line number
			}
			fin.close();
			System.out.println("\nCross Map Reference :-");
			System.out.println(list.ToString());//print the whole list
			System.out.println("Total identifier(s) extracted:"+list.getCount());
		}

		catch (FileNotFoundException e) {//can not find the file
			System.out.println("Failed to open " + args[0]);
		}
		catch (ArrayIndexOutOfBoundsException e) {//user don't type any after the program name
			System.out.println("Usage: CrossReference <word_file>");
		}
    }
}
