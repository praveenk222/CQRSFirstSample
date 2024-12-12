import {Button, Container, Dropdown, Menu, Image} from "semantic-ui-react";
import { Link, NavLink } from "react-router-dom";

interface Props{
    openForm:() => void;
}

export default function Navbar({openForm}:Props){
    // const {userStore: {user, logout}} = useStore();
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item as={NavLink} to='/' header>
                    {/* <img src='/assets/logo.png' alt='logo' style={{marginRight: 10}}/> */}
                    Reactivities
                </Menu.Item>
                <Menu.Item as={NavLink} to='/activities' name='Activities' />
                <Menu.Item as={NavLink} to='/errors' name='Errors' />
                <Menu.Item>
                    <Button onClick={openForm} positive content='Create Activity' />
                </Menu.Item>
                <Menu.Item position='right'>
                    <Image avatar spaced='right'  />
                    <Dropdown pointing='top left' >
                        <Dropdown.Menu>
                            <Dropdown.Item as={Link}  text='My Profile' icon='user' />
                            <Dropdown.Item text='Logout' icon='power' />
                        </Dropdown.Menu>
                    </Dropdown>
                </Menu.Item>
            </Container>
        </Menu>
    )
}