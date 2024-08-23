using QuizApp;

Question[] questions = new Question[]
{
    new Question(
    "What is the capital of Germany", //Question text
    new string[] {"Paris", "Berlin", "London", "Madrid"}, //Answer
    1 //correct Answer index
    ),
    new Question(
    "How much is 2+2", //Question text
    new string[] {"3", "4", "5", "6"}, //Answer
    1 //correct Answer index
    ),
    new Question(
    "Who wrote 'Hamlet'?", //Question text
    new string[] {"Goethe", "Austen", "Shakespeare", "Dickens"}, //Answer
    2 //correct Answer index
    ),
    new Question(
    "How much is 7+2", //Question text
    new string[] {"9", "23", "3", "12"}, //Answer
    0 //correct Answer index
    ),
    new Question(
    "Who won the WorldCup in 2023", //Question text
    new string[] {"Honduras", "Greece", "France", "Argentina"}, //Answer
    3 //correct Answer index
    )
};

Quiz myQuiz = new Quiz(questions);
myQuiz.StartQuiz();

// Console.ReadLine();