using System;



public class answerQuestion {
    public string question;
    public int[] answer ;
    public string[] array2;
    public int trueAnswer;
    public answerQuestion(string ques,string[] array,int[] answer,int trueanswer)
    {
        this.array2 = array;
        this.question = ques;
        this.answer= answer;
        this.trueAnswer = trueanswer;
    }
    
}

class Program
{
    static Random _random = new Random();

    
    static void Shuffle<T>(T[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
           
            int r = i + (int)(_random.NextDouble() * (n - i));
            T t = arr[r];
            arr[r] = arr[i];
            arr[i] = t;
        }
    }
    static void Main(string[] args)

    {
        
        int counter = 0;

        int[] array = {1,2,3,4,5};
        string[] arrayy = {"A:", "B:", "C:", "D:", "E:"};
             
       

        answerQuestion [] array1 = { new answerQuestion("1+2 nece edir?", arrayy,array, 3),new answerQuestion("2+3 nece edir?",arrayy,array,5), new answerQuestion("2+3 nece edir?",arrayy, array, 5),
            new answerQuestion("2+3 nece edir?",arrayy, array, 5), new answerQuestion("2+3 nece edir?",arrayy, array, 5), new answerQuestion("2+3 nece edir?",arrayy, array, 5),
         new answerQuestion("2+3 nece edir?",arrayy, array, 5), new answerQuestion("2+3 nece edir?",arrayy, array, 5)
         , new answerQuestion("2+3 nece edir?",arrayy, array, 5),
            new answerQuestion("2+3 nece edir?",arrayy, array, 5)};
        
  


        //Console.WriteLine(array1[0].question+"\n");
        for (int j=0;j<array1.Length;j++)
        {

            Shuffle(array);
            
            Console.WriteLine(array1[j].question+"\n");
            


            for (int i = 0; i < array1[j].answer.Length; i++)
            {

                
                Console.Write(array1[0].array2[i] + " " + " "+ array1[0].answer[i]+" \n");
                //Console.WriteLine(array1[0].array2[i] + "");


            }
            int ans = int.Parse(Console.ReadLine() );
            
            if (ans == array1[j].trueAnswer)
            {
                

                counter = counter + 10;
                Console.WriteLine("Duzgun cavabdir sizin baliniz:" + counter);
            }
            else
            {
                

                counter = counter + 0;
                Console.WriteLine("Sehv cavabdir sizin baliniz:" + counter);
            }

        }
        
        
    }
}