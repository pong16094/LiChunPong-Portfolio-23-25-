public class ListNode {
	private String data;//store the word
	private int lineNum;//stock the line number
	private ListNode nextString;//connect next word
	private ListNode num;// number node
	private ListNode left;//tree
	private ListNode right;//tree

	public ListNode(int linenum) {//make number node
		this.lineNum = linenum;
		this.nextString = null;
		this.num = null;
	}
	public ListNode(String data,int linenum) {//make new word node and number node
		this.data = data;
		this.nextString = null;
		this.num = null;
		this.num =new ListNode(linenum);
	}
	
	public ListNode(String data) {//for tree
		this.data = data;
		this.left = null;
		this.right = null;
	}

	public String getData() { return data; }
	
	public int getLineNum() { return lineNum; }

	public ListNode getNextString() { return nextString; }

	public ListNode getNum() { return num; }

	public void setNextString(ListNode p) { nextString=p; }

	public void setNum(ListNode p) { num=p; }
	public ListNode getLeft() { return left; }

	public ListNode getRight() { return right; }

	public void setLeft(ListNode p) { left=p; }

	public void setRight(ListNode p) { right=p; }

	
}


