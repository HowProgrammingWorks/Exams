// Replace substring with newstr
'use strict';

const replace = (str, subStr, newStr) => {
  if (subStr === '') return str;
  let res = '';
  while (str.includes(subStr)) {
    const startStr = str.substring(0, str.indexOf(subStr));
    const endOfSubStr = str.indexOf(subStr) + subStr.length;
    str = str.substring(endOfSubStr, str.length);
    res += startStr + newStr;
  }
  return res + str;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
