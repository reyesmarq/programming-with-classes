public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ').Select(static word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            // Loop until we find a word that isn't already hidden
            while (_words[index].IsHidden())
            {
                // Check if the index can move backwards
                if (index > 0 && !_words[index - 1].IsHidden())
                {
                    index--; // Move one index before
                }
                // Check if the index can move forward
                else if (index < _words.Count - 1 && !_words[index + 1].IsHidden())
                {
                    index++; // Move one index ahead
                }
                else
                {
                    // If both adjacent words are hidden or out of range, break the loop
                    break;
                }
            }

            // Hide the word if it's not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
