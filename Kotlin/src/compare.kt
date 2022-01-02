//spread operator (vararg in kotlin) is unsupported in functional style in kotlin
fun <K,V> compare(firstMap: Map<K,V>, secondMap: Map<K,V>): Boolean {
    val keysOfFirstMap = firstMap.keys
    val keysOfSecondMap = secondMap.keys
    var compareBool = true
    return if (keysOfFirstMap.size == keysOfSecondMap.size) {
        for (key in keysOfFirstMap)
            if (firstMap[key] != secondMap[key]) compareBool = false
         compareBool
    }
    else compareBool
}

fun main(){
    val result = compare(mapOf('a' to 1, 'c' to "hello"), mapOf('a' to 1, 'c' to "hello"))
    println(result)
}