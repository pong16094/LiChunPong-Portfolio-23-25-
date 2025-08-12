public class ListBst {
	private ListNode root;
	private ListNode keyword;
	static int count=0;//for the total number
	public ListBst() {
		this.root = null;//main word
		this.keyword = null;//store java keyword list
	}

	public void addListNode(String data, int lineNum) {
		ListNode nowNode=root;
		ListNode nextNode=null;
		int time =0;

		if (root==null) { // empty Node
			root = new ListNode(data, lineNum);
			count++;
			return;
		}

		while (nowNode!=null) {	// find a place for insertion
			nextNode = nowNode;
			if (nowNode.getData().equalsIgnoreCase(data)) //check that word have Node?
			{
				time++;//to distinguish already have node
				break;
			}
			else
				nowNode = nowNode.getNextString();
		}

		if (time>0){//have String node
			if(nowNode.getNum()==null){//find the null number node
			nowNode.setNum(new ListNode(lineNum));
			count++;
			return;
			}
			while(nowNode.getNum()!=null){
				nowNode=nowNode.getNum();
			}
			nowNode.setNum(new ListNode(lineNum));
			count++;
			return;
		}
		else{
			nextNode.setNextString(new ListNode(data,lineNum));//make new String node
			count++;
			return;
		}
	}

	public void addNode(String data) {//make the java keyword tree
		ListNode p=keyword;
		ListNode prev=null;

		if (keyword==null) { // empty tree
			keyword = new ListNode(data);
			return;
		}

		while (p!=null) {	// find a place for insertion
			prev = p;
			if (data.compareTo(p.getData()) < 0)
				p = p.getLeft();
			else
				p = p.getRight();
		}

		if (data.compareTo(prev.getData()) < 0)
			prev.setLeft(new ListNode(data));
		else
			prev.setRight(new ListNode(data));
	}
	public String ToString(){//print the whole wordNode
		String s = "";
		ListNode current = root;
		while (current != null) {
			ListNode num =current.getNum();
			s += current.getData() + ":[";
			while(num!=null){
				s+= num.getLineNum()+ " ";
				num=num.getNum();
			}
			s+= "] \n";
			current = current.getNextString();
		}
		return s;
	}

	public int getCount(){return count;}//get number of count
	public String search(String item) {
		return search(keyword, item);
	}

	public String search(ListNode v, String item) {//is the word in the java keyword tree
		if (v==null)
			return null;
		else if (item.compareTo(v.getData())==0)   //  item == v.getData()
			return v.getData();
		else if (item.compareTo(v.getData())<0)  // item < v.getData()
			return search(v.getLeft(), item);
		else    // item > v.getData()
			return search(v.getRight(), item);
	}
}
