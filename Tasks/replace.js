// Replace substring with newstr
'use strict';

const replace = (str, substr, newstr) => {
  if (substr    === ''){
  return str
  } else{
  src = str
  res = ''
  do {
   const _index = src.indexOf( substr) ; 
   if (_index === -1) { return res + src }else{
   const start = src.substring(0,_index);
   src = src.substring(_index+substr.length,src.length)
   res += start + newstr
 }} while (true); }; };

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
