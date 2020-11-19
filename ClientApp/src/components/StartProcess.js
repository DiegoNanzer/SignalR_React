import React, { Component } from 'react';

const StartProcess = () => {

    const callProcess = () => {

        fetch("/HealthCheckProcess", {
            method: "POST",
        }).then(function (res) { console.log(res) })
            .catch(function (res) { console.log(res) })
    }

    return (
        <div >
            <input type='button' onClick={callProcess} value="Call Process"></input>
        </div>
    );
}

export default StartProcess;
