 fun replace(string: String, subString: String, newString: String){
     if(subString == "") string
     else{
          var res = ""
          do{
              val _index = string.indexOf(subString)
              if(_index == -1) {return (res+string)} else{
                 val start = string.substring(0,_index)
                 string = string.substring(_index+subString.length,string.length)
                 res += start + newString
             } }while (true); } ;};
 fun main(){
     val result = Replace("Hello <username> and bye!", "<username>", "Marcus")
     println(result)
 }