using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00720 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(LongestWord(new string[] { "w", "wo", "wor", "worl", "world" }));
    }

    //    给出一个字符串数组words组成的一本英语词典。
    // 从中找出最长的一个单词，该单词是由words词典中其他单词逐步添加一个字母组成。
    // 若其中有多个可行的答案，则返回答案中字典序最小的单词。
    //若无答案，则返回空字符串。
    //示例 1:
    //输入: 
    //words = ["w","wo","wor","worl", "world"]
    //    输出: "world"
    //解释: 
    //单词"world"可由"w", "wo", "wor", 和 "worl"添加一个字母组成。
    //示例 2:
    //输入: 
    //words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
    //    输出: "apple"
    //解释: 
    //"apply"和"apple"都能由词典中的单词组成。但是"apple"得字典序小于"apply"。
    //注意:
    //所有输入的字符串都只包含小写字母。
    //words数组长度范围为[1, 1000]。
    //words[i] 的长度范围为[1, 30]。
    public string LongestWord(string[] words)
    {
        Trie trie = new Trie();
        int index = 0;
        foreach (string word in words)
        {
            trie.insert(word, ++index); //indexed by 1
        }
        trie.words = words;
        return trie.dfs();
    }
}

class TrieNode
{
    char c;
    public int end;
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public TrieNode(char c)
    {
        this.c = c;
    }
}

class Trie
{
    TrieNode root;
    public string[] words;

    public Trie()
    {
        root = new TrieNode('0');
    }

    public void insert(string word, int index)
    {
        TrieNode cur = root;
        foreach(char c in word.ToCharArray())
        {
            if (!cur.children.ContainsKey(c))
            {
                cur.children.Add(c, new TrieNode(c));
            }
            cur = cur.children[c];
        }
        cur.end = index;
    }

    public string dfs()
    {
        string ans = "";
        Stack<TrieNode> s = new Stack<TrieNode>();
        s.Push(root);
        while (s.Count > 0)
        {
            TrieNode node = s.Pop();
            if(node.end > 0 || node == root)
            {
                if(node != root)
                {
                    string word = words[node.end - 1];
                    if (word.Length > ans.Length ||
                            word.Length == ans.Length && word.CompareTo(ans) < 0)
                    {
                        ans = word;
                    }
                }
                foreach (TrieNode nei in node.children.Values)
                {
                    s.Push(nei);
                }
            }
        }
        return ans;
    }
}
