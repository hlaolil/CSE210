using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();  // Convert text to a list of Word objects
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count <= numberToHide)
        {
            // Hide all visible words if the number to hide is greater than or equal to the visible count
            foreach (var word in visibleWords)
                word.Hide();
        }
        else
        {
            for (int i = 0; i < numberToHide; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index); // Ensure the same word is not hidden multiple times
            }
        }
    }
    
    public string GetDisplayText()
    {
        return $"{_reference}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
    
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}