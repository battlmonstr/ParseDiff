                    { @"^old mode \d+$", OldPermissions },
                    { @"^new mode \d+$", NewPermissions },
        private void OldPermissions(string line)
        {
            Restart();
            file.OldPermissions = line.Split(' ').Last();
        }

        private void NewPermissions(string line)
        {
            Restart();
            file.NewPermissions = line.Split(' ').Last();
        }
