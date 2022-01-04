// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (str, start, end) => {
  let startIndex = str.indexOf(start)
    if ( startIndex === -1 ) return ''
    else {
      startIndex += start.length
      str =  str.substring(startIndex)
      if ( end) {
        let endIndex = str.indexOf( end )
        if (endIndex === -1) {
          return  '' } else { str =  str.substring(0 , endIndex)
            }}}
  return str
}

const result = getValueBetween('Hello <username> and bye!', '<', '>')
console.log(result)
