// Replace substring with newstr
'use strict';

const replace = (str, subStr, newStr) => {
  if (subStr === '') return str;
  let res = '';
  while (str.indexOf(subStr) !== -1) {
    const startStr = str.substring(0, str.indexOf(subStr));
    str = str.substring(str.indexOf(subStr) + subStr.length, str.length);
    res += startStr + newStr;
  }
  return res + str;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
