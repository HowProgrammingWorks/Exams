// Replace substring with newstr

function replace(str, substr,newstr){
  if(substr === ''){
    return str
  }
  else{
    res = ''
    do{
      const index = str.indexOf(substr); 
        if(index === -1){
          return res + str
        }
        else{
          const start = str.substring(0, index);
          str = str.substring(index + substr.length, str.length)
          res += start + newstr
        }
    }while (true);
  };
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
