// Replace substring with newstr
'use strict';


const Replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  }
  let src = str;
  let res = '';
  let index = src.indexOf(substr);
  while (index !== -1) {
    const start = src.substring(0, index);
    src = src.substring(index + substr.length, src.length);
    res += start + newstr;
    index = src.indexOf(substr);
  }
  return res + src;
}

const result = Replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
