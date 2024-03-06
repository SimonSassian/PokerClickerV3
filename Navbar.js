import React from 'react';
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import { useHistory } from 'react-router-dom';

function Navbar() {
    const history = useHistory();

    const handleNavigate = (route) => {
        history.push(route);
    };

    return (
        <AppBar position="static">
            <Toolbar>
                <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                    My Navbar
                </Typography>
                <Button color="inherit" onClick={() => handleNavigate('/game')}>Mäng</Button>
                <Button color="inherit" onClick={() => handleNavigate('/settings')}>Seaded</Button>
                <Button color="inherit" onClick={() => handleNavigate('/scoreboard')}>Skooritabel</Button>
                <Button color="inherit" onClick={() => handleNavigate('/shop')}>Pood</Button>
            </Toolbar>
        </AppBar>
    );
}

export default Navbar;
