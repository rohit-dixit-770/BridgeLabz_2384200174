namespace UndoRedoFunctionality
{
    class Program
    {
        static void Main()
        {
            TextStateLinkedList textEditor = new TextStateLinkedList(10);

            // Simulate typing or performing actions
            textEditor.AddTextState("Initial state.");
            textEditor.AddTextState("Typed 'Hello'.");
            textEditor.AddTextState("Typed 'World!'.");
            textEditor.AddTextState("Deleted 'World!'.");
            textEditor.AddTextState("Typed 'C#'.");

            // Display the current state
            textEditor.DisplayCurrentState();

            // Undo actions
            Console.WriteLine("\nUndoing...");
            textEditor.Undo();
            textEditor.DisplayCurrentState();
            textEditor.Undo();
            textEditor.DisplayCurrentState();

            // Redo actions
            Console.WriteLine("\nRedoing...");
            textEditor.Redo();
            textEditor.DisplayCurrentState();
            textEditor.Redo();
            textEditor.DisplayCurrentState();
            Console.ReadKey();
        }
    }

}