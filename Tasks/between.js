// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (str, fromLeft, fromRight) => {
  let index = str.indexOf(fromLeft)
    if ( index === -1 ) return ''
    else {
      index += fromLeft.length
      str =  str.substring(k)
      if (fromRight) {
        index = str.indexOf(fromRight)
        if (index === -1) {
          return  '' } else { str =  str.substring(0 , index)
            }}}
  return str
}

const result = getValueBetween('Hello <username> and bye!', '<', '>')
console.log(result)
