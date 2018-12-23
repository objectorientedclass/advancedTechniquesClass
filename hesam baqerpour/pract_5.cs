using system;
namespace myNameSpace{

    public class MY_motevaziolazla{
        int width, height, masahat;
        public MY_motevaziolazla(){

        }
        public MY_motevaziolazla(int width, int height){
            this.width = width;
            this.height = height;
        }

        public void showWH(){
            console.writeLine("width is : {0}\nheight is : {1}", width, height);
        }

        public void calc(){
            masahat = width * height ;
            mohit = width * height / 2 ; 
        }
    }

    public class Rectangle : MY_motevaziolazla{
        public override calc (){

        }
    }

    public class Cube : Rectangle{
        
    }

}