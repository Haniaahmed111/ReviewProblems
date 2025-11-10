using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPBasedTodoApp
{
    // Klasse til at repræsentere en enkelt to-do opgave
    class TodoItem
    {
        public string action { get; set; }
        public bool done { get; set; }
    }

    // Klasse til at håndtere en liste af to-do opgaver
    class TodoList
    {
        private List<TodoItem> Items = new List<TodoItem>();

        // Tilføjer et nyt to-do item
        public void Add(TodoItem item)
        {
            Items.Add(item);
        }

        // Markerer en opgave som færdig baseret på dens action-navn
        public void MarkActionDone(string action)
        {
            foreach (var item in Items)
            {
                if (item.action == action)
                {
                    item.done = true;
                }
            }
        }

        // Returnerer alle opgaver, som ikke er færdige
        public List<TodoItem> getTodos()
        {
            return Items.Where(i => i.done == false).ToList();
        }

        // Optional: gør det muligt at printe TodoList som tekst
        public override string ToString()
        {
            return string.Join(", ", getTodos().Select(i => i.action));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tl = new TodoList();
            tl.Add(new TodoItem { action = "Grocery", done = false });
            tl.Add(new TodoItem { action = "Gym", done = false });
            tl.MarkActionDone("Gym");

            foreach (var todo in tl.getTodos())
                Console.WriteLine(todo.action);  // Output: Grocery

            Console.WriteLine(tl); // Output: Grocery
        }
    }
}