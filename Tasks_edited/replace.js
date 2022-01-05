// Replace substring with newstr

function replace(str, substr,newstr){
  if(substr.length == 0){
    return str
  }
  else{
    replaced = ''
    do{
      const index = str.indexOf(substr); 
        if(index === -1){
          return replaced + str
        }
        else{
          const start = str.substring(0, index);
          const end = str.substring(index + substr.length, str.length)
          replaced += start + newstr + end
          return replaced
        }
    }while (true);
  };
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
