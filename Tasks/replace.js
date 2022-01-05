// Replace substring with newstr
'use strict';


const replace = (str, subStr, newStr) => {
  if (subStr === '') {
    return str;
  }
  let res = '';
  let index = str.indexOf(subStr);
  while (index !== -1) {
    const start = str.substring(0, index);
    const end = str.substring(index + subStr.length, str.length);
    str = start + newStr + end;
    index = str.indexOf(subStr);
  }
  return str;
}

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
