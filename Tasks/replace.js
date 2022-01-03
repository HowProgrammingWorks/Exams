// Replace substring with newstr

 const replace = (string, subString,newString)=>{
  if (subString    === ''){
  return string;
  } else{
  let copyString = string;
  let result = '';
  do {
   const index = copyString.indexOf(subString) ; 
   if (index === -1) { return res + copyString }else{
   const start = copyString.substring(0,index);
   copyString = copyString.substring(index + subString.length,copyString.length)
   result += start + newString;
 }} while (true); }; };

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
