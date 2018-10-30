namespace c_sharp {

    class TrieTreeNode {
        public char data;
        public TrieTreeNode[] children;
        public bool isEnd;

        public TrieTreeNode() {
            children = new TrieTreeNode[26];
            isEnd = false;
        }
    }

    class TrieTree {
        public TrieTreeNode root;

        public TrieTree () {
            root = new TrieTreeNode();
        }

        public void Insert(string str) {

            TrieTreeNode cur = root;
            foreach (char c in str) {
                int pos = c - 'a';
                if (cur.children[pos] == null) {
                    TrieTreeNode newNode = new TrieTreeNode();
                    newNode.data = c;
                    cur.children[pos] = newNode;
                }
                cur = cur.children[pos];
            }

            cur.isEnd = true;

        }

        public bool Exists(string str) {
            if (str == null || str.Length <= 0) {
                return false;
            }
            TrieTreeNode cur = root;
            foreach (char c in str) {
                int pos = c - 'a';
                if (cur.children[pos] == null) {
                    return false;
                }
                cur = cur.children[pos];
            }
            return cur.isEnd;
        }
    }

}