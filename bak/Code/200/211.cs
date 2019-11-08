using System;
using System.Collections.Generic;
using System.Linq;
public class WordDictionary
{

    class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public string item;
    }
    TrieNode root = new TrieNode();
    public WordDictionary()
    {

    }

    /** Adds a word into the data structure. */
    public void AddWord(string word)
    {
        var current = root;
        for (int i = 0; i < word.Length; i++)
        {
            var index = word[i] - 'a';
            if (current.children[index] == null)
                current.children[index] = new TrieNode();
            current = current.children[index];
        }
        current.item = word;
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        return Search(word, 0, root);
    }
    private bool Search(string word, int id, TrieNode m)
    {
        if (word.Length == id) return m.item != null;
        var c = word[id];
        if (c == '.')
        {
            for (int i = 0; i < m.children.Length; i++)
            {
                if (m.children[i] != null && Search(word, id + 1, m.children[i]))
                    return true;
            }

        }
        else
        {
            return m.children[c - 'a'] != null && Search(word, id + 1, m.children[c - 'a']);
        }
        return false;
    }
}
