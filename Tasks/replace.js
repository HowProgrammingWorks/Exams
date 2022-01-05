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
    const end = src.substring(index + subStr.length, src.length);
    src = start + newStr + end;
    index = src.indexOf(subStr);
  }
  return src;
}

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
