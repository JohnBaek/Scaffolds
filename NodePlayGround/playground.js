

/** Start Stop watch process
 * @param  {} callback
 * @param  {} interval
 */
function startStopWatch(callback , interval)
{    
    var number = 1;
    callback(number);
    var timer = setInterval((function(){
        number++
        if(!callback(number))
            clearInterval(timer);
    }).bind(this), interval)
}

/** Counter
 * @param  {} number
 */
function counter(number){
    console.log(number);
    return (number < 5) ? true : false;
}

startStopWatch(counter,1000);