var replace = lambda@{ string: String, subString: String, newString: String ->
    if(subString == "") string
     else{
        var stringElse = string
        var resultElse = ""
        do{
            val index = stringElse.indexOf(subString)
            if(index == -1) {return@lambda(resultElse+stringElse)} else{
                val subStringElse = stringElse.substring(0,index)
                stringElse = stringElse.substring(index+subString.length,stringElse.length)
                resultElse += subStringElse + newString
            }}while (true); } ;}
fun main(){
    val result = replace("Hello <username> and bye!", "<username>", "Marcus")
    println(result)
}