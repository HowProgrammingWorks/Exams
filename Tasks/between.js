// Extract substring between prefix and suffix
'use strict';

const extract = (str, prefix, suffix) => {
  i = str.indexOf(prefix)
  if (i !== -1) {
    k = i + prefix.length
    str = str.substring(k)
    i = str.indexOf(suffix)

    if (i !== -1) {
      str = str.substring(0, i)
    } else str = "wrong"

  } else str = "wrong"

  return str
}

const result = extract('Hello <username> and bye!', '<', '>')
console.log(result)
