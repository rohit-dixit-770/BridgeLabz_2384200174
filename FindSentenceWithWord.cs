using System;

class Program{
	static string FindSentenceWithWord(string[] sentences, string word){
		word = word.ToLower();
		
		for(int i=0; i<sentences.Length; i++){
			if(sentences[i].ToLower().Contains(word)){
				return sentences[i];
			}
		}
		return "No sentence contains the word";
	}
	static void Main(){
		string[] sentences={
			"The sun is shining brightly.",
            "I love programming in C#.",
            "Have a great day!",
            "This is an example of a search problem."
		};
		
		Console.Write("Enter a word to search for: ");
		string searchWord = Console.ReadLine();
		
		string result = FindSentenceWithWord(sentences,searchWord);
		Console.WriteLine("Result: "+result);
	}
}