// Extract substring between prefix and suffix

const getvaluebetween = (str, start, end) => {
  const firstIndex = str.indexOf(start) + start.length
  const lastIndex = str.indexOf(end)
    if ( firstIndex === -1 || lastIndex === -1) return ''
    else {
      str =  str.substring(firstIndex)
      str =  str.substring(0 , lastIndex)
    }
  return str
}

const result = getvaluebetween('Hello <username> and bye!', '<', '>')
console.log(result)
