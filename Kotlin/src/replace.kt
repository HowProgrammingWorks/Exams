fun replace(string: String, subString: String, newString: String): String {
    if (subString == "") return string
    var stringElse = string
    var resultElse = ""
    while (true) {
        val index = stringElse.indexOf(subString)
        if (index == -1) {
            resultElse += stringElse
            return resultElse
        }
        val subStringElse = stringElse.substring(0,index)
        val indexSubString = index + subString.length
        stringElse = stringElse.substring(indexSubString,stringElse.length)
        resultElse += subStringElse + newString
    }
}

fun main() {
    val result = replace("Hello <username> and bye!", "<username>", "Marcus")
    println(result)
}
