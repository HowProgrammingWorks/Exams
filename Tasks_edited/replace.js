// Replace substring with newstr

function replace(str, substr,newstr){
  if(substr === ''){
    return str
  }
  else{
    src = str
    res = ''
    do{
      const index = src.indexOf(substr); 
        if(index === -1){
          return res + src
        }
        else{
          const start = src.substring(0, index);
          src = src.substring(index + substr.length, src.length)
          res += start + newstr
        }
    }while (true);
  };
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
