// Extract substring between prefix and suffix

const getvaluebetween = (str, start, end) => {
  const firstIndex = str.indexOf(start)
    if ( firstIndex === -1 ) return ''
    else {
      const k = firstIndex + start.length
      str =  str.substring(end)
      if (end) {
        const lastIndex = str.indexOf(end)
        if (lastIndex === -1) {
          return  '' } else { str =  str.substring(0 , lastIndex)
            }}}
  return str
}

const result = getvaluebetween('Hello <username> and bye!', '<', '>')
console.log(result)
