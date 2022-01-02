// Replace substring with newstr
'use strict';

const NOT_FOUND = -1;
const BEGIN = 0;

const replace = (str, subStr, newStr) => {
  if (subStr === '') {
    return str;
  }
  let res = '';
  while (str.indexOf(subStr) !== NOT_FOUND) {
    const start = str.substring(BEGIN, str.indexOf(subStr));
    str = str.substring(str.indexOf(subStr) + subStr.length, str.length);
    res += start + newStr;
  }
  return res + str;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
