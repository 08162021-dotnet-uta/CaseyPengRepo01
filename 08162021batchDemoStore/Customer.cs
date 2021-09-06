namespace _08162021batchDemoStore
{
    public class Customer
    {//private var is used to validate the input , if you don't create one, 
    //the program will create one for you and you won't be able to see it or manage

        private string fname;
        public string Fname { get{
            return this.fname;
        } set{
            if(value.Length > 50 || value.Length==0){
                this.fname ="invalid input";
            }else{
                this.fname = value;
            }
        } }
        public string Lname { get; set; }
        
        //Since you manually create a construtor in line 22, the default one is no longer provided, so you need to create one 
        public Customer(){}
        

        public Customer(string fname, string lname){
            this.Fname = fname;
            this.Lname = lname;
        }
        
    }
}