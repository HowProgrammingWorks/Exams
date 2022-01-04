// Convert number to file size in bytes, kb, mb, and gb

let size=size=>{
  if (size === 0) return '0';
  else {
    const exp = Math.floor(Math.log(size)/Math.log(1000));
    if (exp==0) return size + ' byte'
    else if(exp==1) return Math.round(size / 1000) + ' kb'
    else if(exp==2) return Math.round(size / 1000000) + ' mb'
    else if(exp==3) return Math.round(size / 1000000000) + ' gb'
  }
}

const result = size(123456)
console.log(result)
