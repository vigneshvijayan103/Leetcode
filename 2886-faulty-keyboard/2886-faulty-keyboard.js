/**
 * @param {string} s
 * @return {string}
 */
var finalString = function(s) {
    let rev="";
for(i=0;i<s.length;i++){
    if(s[i]==='i'){
       rev= rev.split('').reverse().join('');
    }else{
        rev=rev+s[i];
    
    }
    }
    return rev
};