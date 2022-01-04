// Extract substring between prefix and suffix
'use strict';

const extract = (str, p, s) => {
  i = str.indexOf(p)
  if (i === -1) return ''
  else {
    k = i + p.length
    str = str.substring(k)
    if (s) {
      i = str.indexOf(s)
      if (i === -1) {
        return ''
      } else {
        str = str.substring(0, i)
      }
    }
  }
  return str
}

const result = extract('Hello <username> and bye!', '<', '>')
console.log(result)
