// Extract substring between prefix and suffix

const getvaluebetween = (str, p, s) => {
  const i = str.indexOf(p)
    if ( i === -1 ) return ''
    else {
      k = i + p.length
      str =  str.substring(k)
      if ( s) {
        const i = str.indexOf( s )
        if (i === -1) {
          return  '' } else { str =  str.substring(0 , i)
            }}}
  return str
}

const result = getvaluebetween('Hello <username> and bye!', '<', '>')
console.log(result)
