using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }

    internal class Collections
    {
        public void TestList()
        {
            List<Question> list = new List<Question>
            {
                new Question {Id=1, Title="question 1"},
                new Question {Id=2, Title="question 2"},
                new Question {Id=3, Title="question 3"}
            };

            Console.WriteLine("Iterating the list =");
            foreach(Question item in list)
            {
                Console.WriteLine($"Id      {item.Id}");
                Console.WriteLine($"Title   {item.Title}");
            }

            Console.WriteLine("Indexing into list - ");
            Console.WriteLine($"Id {list[0].Id}     Title {list[0].Title}");
        }

        public void TestDictionary()
        {
            Dictionary<Question, int> dictionary = new Dictionary<Question, int>
            {
                { new Question() {Id=1, Title="question 1"}, 1 },
                { new Question() {Id=2, Title="question 2"}, 2 },
                { new Question(){Id=3, Title="question 3"}, 3 }
            };
            Console.WriteLine("Iterating dcitionary ");


            foreach(var item in dictionary)
            {
                Console.WriteLine($"number/value {item.Value} question {item.Key.Title}");
            }

            foreach(var key in dictionary.Keys)
            {
                Console.WriteLine($"number/value {dictionary[key]} question {key.Id}, {key.Title}");
            }

            Console.WriteLine("------------- End dictionary ---------------");

        }

        public void TestStacks()
        {
            Question[] questions = new Question[3] {
                new Question() {Id=1, Title="question-1"},
                new Question() {Id=2, Title="question-1"},
                new Question(){Id=3, Title="question-2"}
                };

            Stack<Question> stack = new Stack<Question>(questions);
            {
               
            };
        }

        public void TestQueues()
        {
            Queue<Question> queue = new Queue<Question>();

        }

        public void TestSortedList()
        {

        }

        public void TestKeyValuePair()
        {

        }
    }
}
