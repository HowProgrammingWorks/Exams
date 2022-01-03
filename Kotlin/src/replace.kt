 var Replace = lambda@{ str: String, substr: String, newstr: String ->
     if(substr == ""){
         str
     } else{
         var src = str
         var res = ""
         do{
             val _index = src.indexOf(substr)
             if(_index == -1) {return@lambda(res+src)} else{
                 val start = src.substring(0,_index)
                 src = src.substring(_index+substr.length,src.length)
                 res += start + newstr
             }}while (true); } ;}
 fun main(){
     val result = Replace("Hello <username> and bye!", "<username>", "Marcus")
     println(result)
 }