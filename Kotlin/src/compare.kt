//spread operator (vararg in kotlin) is unsupported in functional style in kotlin
fun <K,V> compare(first_values: Map<K,V>, second_values: Map<K,V>): Boolean {
    var a = first_values.keys
    var b = second_values.keys
    if(a.joinToString("-") != b.joinToString("-") ) return false
    var e = true
    for (c in a){
        if (first_values[c] == second_values[c]) e = e && true
        else { e = e && false }
    }
    return e
}
fun main(){
    val result = compare(mapOf('a' to 1, 'c' to "hello"), mapOf('a' to 1, 'c' to "hello"))
    println(result)
}