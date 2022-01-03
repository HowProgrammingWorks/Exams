// Replace substring with newstr

 const replace = (string, subString, newString) =>{
  if (subString  === '') return string; 
  let copyString = string;
  let result = '';
  while(true){
   const index = copyString.indexOf(subString) ; 
   if (index === -1)  return result + copyString; 
   const start = copyString.substring(0,index);
   copyString = copyString.substring(index + subString.length,copyString.length)
   result += start + newString;
  }  
 };

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
