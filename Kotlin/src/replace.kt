var replace = lambda@{ string: String, subString: String, newString: String ->
    if(subString == "") string
     else{
        var src = string
        var res = ""
        do{
            val _index = src.indexOf(subString)
            if(_index == -1) {return@lambda(res+src)} else{
                val start = src.substring(0,_index)
                src = src.substring(_index+subString.length,src.length)
                res += start + newString
            }}while (true); } ;}
fun main(){
    val result = replace("Hello <username> and bye!", "<username>", "Marcus")
    println(result)
}