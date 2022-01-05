// Replace substring with newstr
'use strict';


const replace = (str, subStr, newStr) => {
  if (subStr === '') {
    return str;
  }
  let src = str;
  let res = '';
  let index = src.indexOf(subStr);
  while (index !== -1) {
    const start = src.substring(0, index);
    src = src.substring(index + subStr.length, src.length);
    res += start + newStr;
    index = src.indexOf(subStr);
  }
  return res + src;
}

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
