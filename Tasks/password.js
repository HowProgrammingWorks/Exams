// Generate random password

const generateKey = (n, characters) => {
  let combination = ''
  if(n <= characters.length){

  for(let i = 0; i < n; i++){
 combination += characters[Math.floor(Math.random() * (characters.length))]
  }
  
}
else{
  console.log('Wrong Input')
}
return combination
}

require('../Tests/password.js')(generateKey);
