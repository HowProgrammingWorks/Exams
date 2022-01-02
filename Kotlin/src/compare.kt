//spread operator (vararg in kotlin) is unsupported in functional style in kotlin
fun <K,V> compare(firstMap: Map<K,V>, secondMap: Map<K,V>): Boolean {
    val keysOfFirstMap = firstMap.keys
    val keysOfSecondMap = secondMap.keys
    var e = true
    for (c in keysOfFirstMap){
        if (firstMap[c] == secondMap[c]) e = e && true
        else { e = e && false }
    }
    return e
}
fun main(){
    val result = compare(mapOf('a' to 1, 'c' to "hello"), mapOf('a' to 1, 'c' to "hello"))
    println(result)
}