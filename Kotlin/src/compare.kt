//spread operator (vararg in kotlin) is unsupported in functional style in kotlin
fun <K,V> compare(FIRST_MAP: Map<K,V>, SECOND_MAP: Map<K,V>): Boolean {
    val KEYS_OF_FIRST_MAP = FIRST_MAP.keys
    val KEYS_OF_SECOND_MAP = SECOND_MAP.keys
    var e = true
    for (c in KEYS_OF_FIRST_MAP){
        if (FIRST_MAP[c] == SECOND_MAP[c]) e = e && true
        else { e = e && false }
    }
    return e
}
fun main(){
    val result = compare(mapOf('a' to 1, 'c' to "hello"), mapOf('a' to 1, 'c' to "hello"))
    println(result)
}