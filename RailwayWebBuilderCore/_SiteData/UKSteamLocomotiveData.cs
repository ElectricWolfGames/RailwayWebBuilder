using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData;

public static class UKSteamLocomotiveData
{
    // ── All known UK steam CMEs / Locomotive Superintendents, sorted by ActiveFrom ──
    public static readonly IReadOnlyList<DesignerInfo> AllDesigners = new List<DesignerInfo>
    {
        new() { Name = "John Ramsbottom",        RailwayName = "London & North Western Railway",      RailwayCode = "LNWR", ActiveFrom = 1857, ActiveTo = 1871, Role = "Locomotive Superintendent" },
        new() { Name = "Patrick Stirling",        RailwayName = "Great Northern Railway",              RailwayCode = "GNR",  ActiveFrom = 1866, ActiveTo = 1895, Role = "Locomotive Superintendent" },
        new() { Name = "David Jones",             RailwayName = "Highland Railway",                    RailwayCode = "HR",   ActiveFrom = 1870, ActiveTo = 1896, Role = "Locomotive Superintendent" },
        new() { Name = "William Stroudley",       RailwayName = "London, Brighton & South Coast Rly", RailwayCode = "LBSCR",ActiveFrom = 1870, ActiveTo = 1889, Role = "Locomotive Superintendent" },
        new() { Name = "F. W. Webb",              RailwayName = "London & North Western Railway",      RailwayCode = "LNWR", ActiveFrom = 1871, ActiveTo = 1903, Role = "Chief Mechanical Engineer" },
        new() { Name = "Samuel Johnson",          RailwayName = "Midland Railway",                     RailwayCode = "MR",   ActiveFrom = 1873, ActiveTo = 1903, Role = "Locomotive Superintendent" },
        new() { Name = "William Dean",            RailwayName = "Great Western Railway",               RailwayCode = "GWR",  ActiveFrom = 1877, ActiveTo = 1902, Role = "Locomotive Superintendent" },
        new() { Name = "William Adams",           RailwayName = "London & South Western Railway",      RailwayCode = "LSWR", ActiveFrom = 1878, ActiveTo = 1895, Role = "Locomotive Superintendent" },
        new() { Name = "James Stirling",          RailwayName = "South Eastern Railway",               RailwayCode = "SER",  ActiveFrom = 1878, ActiveTo = 1898, Role = "Locomotive Superintendent" },
        new() { Name = "T. W. Worsdell",          RailwayName = "North Eastern Railway",               RailwayCode = "NER",  ActiveFrom = 1885, ActiveTo = 1890, Role = "Locomotive Superintendent" },
        new() { Name = "James Holden",            RailwayName = "Great Eastern Railway",               RailwayCode = "GER",  ActiveFrom = 1885, ActiveTo = 1907, Role = "Locomotive Superintendent" },
        new() { Name = "John Aspinall",           RailwayName = "Lancashire & Yorkshire Railway",      RailwayCode = "LYR",  ActiveFrom = 1886, ActiveTo = 1899, Role = "Locomotive Superintendent" },
        new() { Name = "R. J. Billinton",         RailwayName = "London, Brighton & South Coast Rly", RailwayCode = "LBSCR",ActiveFrom = 1890, ActiveTo = 1904, Role = "Locomotive Superintendent" },
        new() { Name = "Wilson Worsdell",         RailwayName = "North Eastern Railway",               RailwayCode = "NER",  ActiveFrom = 1890, ActiveTo = 1910, Role = "Chief Mechanical Engineer" },
        new() { Name = "Dugald Drummond",         RailwayName = "London & South Western Railway",      RailwayCode = "LSWR", ActiveFrom = 1895, ActiveTo = 1912, Role = "Locomotive Superintendent" },
        new() { Name = "John McIntosh",           RailwayName = "Caledonian Railway",                  RailwayCode = "CR",   ActiveFrom = 1895, ActiveTo = 1914, Role = "Locomotive Superintendent" },
        new() { Name = "H. A. Ivatt",             RailwayName = "Great Northern Railway",              RailwayCode = "GNR",  ActiveFrom = 1896, ActiveTo = 1911, Role = "Locomotive Superintendent" },
        new() { Name = "Harry Wainwright",        RailwayName = "South Eastern & Chatham Railway",     RailwayCode = "SECR", ActiveFrom = 1899, ActiveTo = 1913, Role = "Locomotive Superintendent" },
        new() { Name = "John G. Robinson",        RailwayName = "Great Central Railway",               RailwayCode = "GCR",  ActiveFrom = 1900, ActiveTo = 1922, Role = "Chief Mechanical Engineer" },
        new() { Name = "George Jackson Churchward",RailwayName = "Great Western Railway",              RailwayCode = "GWR",  ActiveFrom = 1902, ActiveTo = 1921, Role = "Chief Mechanical Engineer" },
        new() { Name = "Richard Deeley",          RailwayName = "Midland Railway",                     RailwayCode = "MR",   ActiveFrom = 1904, ActiveTo = 1909, Role = "Chief Mechanical Engineer" },
        new() { Name = "George Hughes",           RailwayName = "Lancashire & Yorkshire / LMS",        RailwayCode = "LMS",  ActiveFrom = 1904, ActiveTo = 1925, Role = "Chief Mechanical Engineer" },
        new() { Name = "Nigel Gresley",           RailwayName = "Great Northern / LNER",               RailwayCode = "LNER", ActiveFrom = 1911, ActiveTo = 1941, Role = "Chief Mechanical Engineer" },
        new() { Name = "Robert Urie",             RailwayName = "London & South Western Railway",      RailwayCode = "LSWR", ActiveFrom = 1912, ActiveTo = 1922, Role = "Chief Mechanical Engineer" },
        new() { Name = "Richard Maunsell",        RailwayName = "SE&CR / Southern Railway",            RailwayCode = "SR",   ActiveFrom = 1913, ActiveTo = 1937, Role = "Chief Mechanical Engineer" },
        new() { Name = "Henry Fowler",            RailwayName = "Midland Railway / LMS",               RailwayCode = "LMS",  ActiveFrom = 1909, ActiveTo = 1931, Role = "Chief Mechanical Engineer" },
        new() { Name = "Charles Collett",         RailwayName = "Great Western Railway",               RailwayCode = "GWR",  ActiveFrom = 1921, ActiveTo = 1941, Role = "Chief Mechanical Engineer" },
        new() { Name = "William Stanier",         RailwayName = "London Midland & Scottish Railway",   RailwayCode = "LMS",  ActiveFrom = 1932, ActiveTo = 1944, Role = "Chief Mechanical Engineer" },
        new() { Name = "Edward Thompson",         RailwayName = "London & North Eastern Railway",      RailwayCode = "LNER", ActiveFrom = 1941, ActiveTo = 1946, Role = "Chief Mechanical Engineer" },
        new() { Name = "F. W. Hawksworth",        RailwayName = "Great Western Railway",               RailwayCode = "GWR",  ActiveFrom = 1941, ActiveTo = 1947, Role = "Chief Mechanical Engineer" },
        new() { Name = "Oliver Bulleid",          RailwayName = "Southern Railway",                    RailwayCode = "SR",   ActiveFrom = 1937, ActiveTo = 1948, Role = "Chief Mechanical Engineer" },
        new() { Name = "H. G. Ivatt",             RailwayName = "London Midland & Scottish Railway",   RailwayCode = "LMS",  ActiveFrom = 1945, ActiveTo = 1947, Role = "Chief Mechanical Engineer" },
        new() { Name = "Arthur Peppercorn",       RailwayName = "London & North Eastern Railway",      RailwayCode = "LNER", ActiveFrom = 1946, ActiveTo = 1948, Role = "Chief Mechanical Engineer" },
        new() { Name = "Robert Riddles",          RailwayName = "British Railways",                    RailwayCode = "BR",   ActiveFrom = 1948, ActiveTo = 1953, Role = "Member (Mechanical & Electrical Engineering)" },
    };

    public static readonly IReadOnlyList<SteamLocoEntry> AllLocos = new List<SteamLocoEntry>
    {
        // ── Nigel Gresley (GNR / LNER) ────────────────────────────────────────────
        new() { ClassName = "LNER Class A1 (original)", WhyteNotation = "4-6-2", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1922–1925", TotalProduced = 52, Description = "Gresley's first Pacific; the originals were rebuilt as the famous A3 class." },
        new() { ClassName = "LNER Class A3", WhyteNotation = "4-6-2", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1928–1935", TotalProduced = 79, Description = "World-famous Pacifics including Flying Scotsman (4472), iconic express locomotives of the LNER.", CollectionKey = "Class A3" },
        new() { ClassName = "LNER Class A4", WhyteNotation = "4-6-2", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1935–1938", TotalProduced = 35, Description = "Streamlined Pacifics; Mallard holds the world steam speed record of 126 mph (1938).", CollectionKey = "Class A4" },
        new() { ClassName = "LNER Class P2", WhyteNotation = "2-8-2", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1934–1936", TotalProduced = 6, Description = "Powerful Mikado 2-8-2 for the heavily graded Edinburgh–Aberdeen route." },
        new() { ClassName = "LNER Class V2", WhyteNotation = "2-6-2", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1936–1944", TotalProduced = 184, Description = "Mixed-traffic 'Green Arrow' class; capable of handling express passenger and heavy freight." },
        new() { ClassName = "LNER Class K3", WhyteNotation = "2-6-0", Designer = "Nigel Gresley", PrimaryBuilder = "Darlington Works", BuildDate = "1920–1937", TotalProduced = 193, Description = "Powerful GNR-derived Moguls for freight and mixed-traffic work across the LNER." },
        new() { ClassName = "LNER Class K4", WhyteNotation = "2-6-0", Designer = "Nigel Gresley", PrimaryBuilder = "Darlington Works", BuildDate = "1937–1939", TotalProduced = 6, Description = "Three-cylinder Moguls designed specifically for the demanding West Highland Line." },
        new() { ClassName = "LNER Class N2", WhyteNotation = "0-6-2T", Designer = "Nigel Gresley", PrimaryBuilder = "North British Locomotive Co", BuildDate = "1920–1929", TotalProduced = 107, Description = "Condensing suburban tank engines for London King's Cross services." },
        new() { ClassName = "LNER Class J50", WhyteNotation = "0-6-0T", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1922–1939", TotalProduced = 102, Description = "Heavy shunting and trip-working tank engines used across the LNER." },
        new() { ClassName = "LNER Class O2", WhyteNotation = "2-8-0", Designer = "Nigel Gresley", PrimaryBuilder = "Doncaster Works", BuildDate = "1918–1932", TotalProduced = 67, Description = "Heavy freight eight-coupled locomotives derived from the GNR O1 class." },

        // ── William Stanier (LMS) ─────────────────────────────────────────────────
        new() { ClassName = "LMS Princess Royal Class", WhyteNotation = "4-6-2", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1933–1935", TotalProduced = 13, Description = "Stanier's first Pacific design for the LMS, influenced by GWR King class principles." },
        new() { ClassName = "LMS Princess Coronation Class", WhyteNotation = "4-6-2", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1937–1948", TotalProduced = 38, Description = "The ultimate LMS express Pacific, also known as the Duchess class; some built in streamlined form." },
        new() { ClassName = "LMS Jubilee Class", WhyteNotation = "4-6-0", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1934–1936", TotalProduced = 191, Description = "Three-cylinder express passenger engines named after British colonies and naval victories.", CollectionKey = "Jubilee Class" },
        new() { ClassName = "LMS Class 5 (Black Five)", WhyteNotation = "4-6-0", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1934–1951", TotalProduced = 842, Description = "The most versatile LMS locomotive; equally at home on express passenger and fitted freight work.", CollectionKey = "LMS Class 5" },
        new() { ClassName = "LMS Class 8F", WhyteNotation = "2-8-0", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1935–1946", TotalProduced = 852, Description = "Standard heavy freight engine adopted by the War Department; saw service across Europe and the Middle East.", CollectionKey = "LMS Stanier 8F Class" },
        new() { ClassName = "LMS Stanier 2-6-4T", WhyteNotation = "2-6-4T", Designer = "William Stanier", PrimaryBuilder = "Derby Works", BuildDate = "1935–1943", TotalProduced = 206, Description = "Powerful suburban and semi-fast passenger tank engines for the LMS." },
        new() { ClassName = "LMS Stanier 2-6-2T", WhyteNotation = "2-6-2T", Designer = "William Stanier", PrimaryBuilder = "Derby Works", BuildDate = "1935–1938", TotalProduced = 139, Description = "Light branch line and suburban passenger tank engines." },
        new() { ClassName = "LMS Stanier 2-6-0", WhyteNotation = "2-6-0", Designer = "William Stanier", PrimaryBuilder = "Crewe Works", BuildDate = "1933–1934", TotalProduced = 40, Description = "A lightweight mixed-traffic Mogul, the first Stanier design for the LMS.", CollectionKey = "Stanier Mogul" },

        // ── Robert Riddles (BR Standard Classes) ──────────────────────────────────
        new() { ClassName = "BR Standard Class 8P Duke of Gloucester", WhyteNotation = "4-6-2", Designer = "Robert Riddles", PrimaryBuilder = "Crewe Works", BuildDate = "1954", TotalProduced = 1, Description = "The sole member of this class; rebuilt after withdrawal and fully restored to working order." },
        new() { ClassName = "BR Standard Class 7MT Britannia", WhyteNotation = "4-6-2", Designer = "Robert Riddles", PrimaryBuilder = "Crewe Works", BuildDate = "1951–1954", TotalProduced = 55, Description = "Named express passenger Pacifics; the first BR Standard class to enter service." },
        new() { ClassName = "BR Standard Class 6MT Clan", WhyteNotation = "4-6-2", Designer = "Robert Riddles", PrimaryBuilder = "Crewe Works", BuildDate = "1951–1952", TotalProduced = 10, Description = "Lightweight Pacifics allocated to Scotland; only ten were built before the project was abandoned." },
        new() { ClassName = "BR Standard Class 5MT", WhyteNotation = "4-6-0", Designer = "Robert Riddles", PrimaryBuilder = "Derby Works", BuildDate = "1951–1957", TotalProduced = 172, Description = "Mixed-traffic successor to the LMS Black Five, widely used across all BR regions.", CollectionKey = "BR Standard 5" },
        new() { ClassName = "BR Standard Class 4MT 4-6-0", WhyteNotation = "4-6-0", Designer = "Robert Riddles", PrimaryBuilder = "Swindon Works", BuildDate = "1951–1957", TotalProduced = 80, Description = "Light mixed-traffic tender engines for secondary and branch line work.", CollectionKey = "BR Standard 4 MT 2-6-4" },
        new() { ClassName = "BR Standard Class 4MT 2-6-4T", WhyteNotation = "2-6-4T", Designer = "Robert Riddles", PrimaryBuilder = "Brighton Works", BuildDate = "1951–1957", TotalProduced = 155, Description = "Suburban and branch passenger tank engines; many were allocated to Southern Region.", CollectionKey = "BR Standard 4 Tank" },
        new() { ClassName = "BR Standard Class 4MT 2-6-0", WhyteNotation = "2-6-0", Designer = "Robert Riddles", PrimaryBuilder = "Doncaster Works", BuildDate = "1953–1957", TotalProduced = 115, Description = "Light freight and mixed-traffic Moguls for rural and secondary routes." },
        new() { ClassName = "BR Standard Class 3MT 2-6-2T", WhyteNotation = "2-6-2T", Designer = "Robert Riddles", PrimaryBuilder = "Swindon Works", BuildDate = "1952–1955", TotalProduced = 45, Description = "Light passenger tank engines for branch line and suburban services." },
        new() { ClassName = "BR Standard Class 2MT 2-6-0", WhyteNotation = "2-6-0", Designer = "Robert Riddles", PrimaryBuilder = "Darlington Works", BuildDate = "1952–1956", TotalProduced = 65, Description = "Light mixed-traffic tender engines, the development of Ivatt's LMS Class 2.", CollectionKey = "BR Standard 2" },
        new() { ClassName = "BR Standard Class 2MT 2-6-2T", WhyteNotation = "2-6-2T", Designer = "Robert Riddles", PrimaryBuilder = "Crewe Works", BuildDate = "1953–1957", TotalProduced = 30, Description = "Light branch line tank engines based on the Ivatt LMS Class 2 tank design." },
        new() { ClassName = "BR Standard Class 9F", WhyteNotation = "2-10-0", Designer = "Robert Riddles", PrimaryBuilder = "Swindon Works", BuildDate = "1954–1960", TotalProduced = 251, Description = "The most powerful BR Standard class; built for heavy freight but used successfully on express passenger work.", CollectionKey = "BR Standard 9F" },

        // ── Charles Collett (GWR) ─────────────────────────────────────────────────
        new() { ClassName = "GWR Castle Class", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1923–1950", TotalProduced = 171, Description = "GWR's premier express passenger locomotives; benchmark of British locomotive design in their era." },
        new() { ClassName = "GWR King Class", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1927–1930", TotalProduced = 30, Description = "The most powerful 4-6-0s in Britain; four-cylinder engines for GWR's heaviest express services." },
        new() { ClassName = "GWR Hall Class", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1928–1943", TotalProduced = 259, Description = "Mixed-traffic development of the Saint class; one of the most successful GWR tender locomotives.", CollectionKey = "GWR Hall Class" },
        new() { ClassName = "GWR Modified Hall", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1944–1950", TotalProduced = 71, Description = "Improved Hall class with detail modifications by F. W. Hawksworth for improved steaming." },
        new() { ClassName = "GWR Grange Class", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1936–1939", TotalProduced = 80, Description = "Mixed-traffic engines rebuilt using new frames and the driving wheels from withdrawn 43xx Moguls.", CollectionKey = "GWR 2900 Grange" },
        new() { ClassName = "GWR Manor Class", WhyteNotation = "4-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1938–1950", TotalProduced = 30, Description = "Light 4-6-0 for secondary and cross-country routes where the heavier Hall class was prohibited." },
        new() { ClassName = "GWR 5700 Pannier Tank", WhyteNotation = "0-6-0PT", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1929–1950", TotalProduced = 863, Description = "The most numerous GWR class; ubiquitous pannier tanks for shunting, local goods, and branch work.", CollectionKey = "GWR 5700 Pannier" },
        new() { ClassName = "GWR 5600 Class", WhyteNotation = "0-6-2T", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1924–1928", TotalProduced = 200, Description = "Tank engines built primarily for the South Wales Valleys colliery and passenger services.", CollectionKey = "GWR 5600" },
        new() { ClassName = "GWR 2884 Class", WhyteNotation = "2-8-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1938–1942", TotalProduced = 83, Description = "A development of the Churchward 28xx class with a larger cab and other improvements.", CollectionKey = "GWR 2884" },
        new() { ClassName = "GWR 2251 Class", WhyteNotation = "0-6-0", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1930–1948", TotalProduced = 120, Description = "Light mixed-traffic 0-6-0 tender engines for secondary and branch line work." },
        new() { ClassName = "GWR 1366 Class Pannier Tank", WhyteNotation = "0-6-0PT", Designer = "Charles Collett", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1934", TotalProduced = 6, Description = "Small dock and harbour shunting engines, including the famous Weymouth quay tramway locomotives.", CollectionKey = "GWR Pannier" },

        // ── George Jackson Churchward (GWR) ───────────────────────────────────────
        new() { ClassName = "GWR Star Class", WhyteNotation = "4-6-0", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1907–1923", TotalProduced = 73, Description = "The first truly successful British express four-cylinder 4-6-0; forerunner of Castle and King classes." },
        new() { ClassName = "GWR Saint Class", WhyteNotation = "4-6-0", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1902–1913", TotalProduced = 77, Description = "Foundational two-cylinder express 4-6-0; established the principles used in all subsequent GWR 4-6-0s.", CollectionKey = "GWR 2900 Saint" },
        new() { ClassName = "GWR 28xx Class", WhyteNotation = "2-8-0", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1903–1919", TotalProduced = 84, Description = "Britain's first production 2-8-0; pioneered the design for heavy freight eight-coupled locomotives.", CollectionKey = "GWR 28xx Class Pannier" },
        new() { ClassName = "GWR 43xx Mogul", WhyteNotation = "2-6-0", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1911–1932", TotalProduced = 342, Description = "The GWR's standard mixed-traffic Mogul; highly capable and widely used for goods and passenger work." },
        new() { ClassName = "GWR 4500 Prairie Tank", WhyteNotation = "2-6-2T", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1906–1915", TotalProduced = 75, Description = "Medium-power prairie tanks for suburban and branch passenger services across the GWR." },
        new() { ClassName = "GWR 4575 Prairie Tank", WhyteNotation = "2-6-2T", Designer = "George Jackson Churchward", PrimaryBuilder = "GWR Swindon Works", BuildDate = "1927–1929", TotalProduced = 100, Description = "Improved and enlarged 4500 class prairie tanks with a larger cab and modified boiler." },

        // ── Oliver Bulleid (SR) ───────────────────────────────────────────────────
        new() { ClassName = "SR Merchant Navy Class", WhyteNotation = "4-6-2", Designer = "Oliver Bulleid", PrimaryBuilder = "Eastleigh Works", BuildDate = "1941–1949", TotalProduced = 30, Description = "Innovative air-smoothed express Pacifics; later rebuilt to conventional form by BR." },
        new() { ClassName = "SR West Country Class", WhyteNotation = "4-6-2", Designer = "Oliver Bulleid", PrimaryBuilder = "Brighton Works", BuildDate = "1945–1951", TotalProduced = 66, Description = "Light Pacifics for services in the West Country; many rebuilt to conventional form by BR.", CollectionKey = "West Country Class" },
        new() { ClassName = "SR Battle of Britain Class", WhyteNotation = "4-6-2", Designer = "Oliver Bulleid", PrimaryBuilder = "Brighton Works", BuildDate = "1946–1951", TotalProduced = 44, Description = "Identical to the West Country class; named for RAF Battle of Britain squadrons and aces.", CollectionKey = "Battle of Britain" },
        new() { ClassName = "SR Q1 Class", WhyteNotation = "0-6-0", Designer = "Oliver Bulleid", PrimaryBuilder = "Brighton Works", BuildDate = "1942", TotalProduced = 40, Description = "Functional wartime austerity freight engines; the most powerful 0-6-0 in Britain." },
        new() { ClassName = "SR Leader Class", WhyteNotation = "0-6-6-0T", Designer = "Oliver Bulleid", PrimaryBuilder = "Brighton Works", BuildDate = "1949–1950", TotalProduced = 1, Description = "Highly experimental double-bogie tank locomotive; technically problematic and scrapped without entering service." },

        // ── Richard Maunsell (SR) ─────────────────────────────────────────────────
        new() { ClassName = "SR Schools Class (V)", WhyteNotation = "4-4-0", Designer = "Richard Maunsell", PrimaryBuilder = "Eastleigh Works", BuildDate = "1930–1935", TotalProduced = 40, Description = "The most powerful 4-4-0 ever built in Britain; designed for the restricted Hastings line.", CollectionKey = "GWR Schools Class, SR V Class" },
        new() { ClassName = "SR Lord Nelson Class", WhyteNotation = "4-6-0", Designer = "Richard Maunsell", PrimaryBuilder = "Eastleigh Works", BuildDate = "1926–1929", TotalProduced = 16, Description = "Four-cylinder express passenger engines; when introduced, jointly the most powerful 4-6-0 in Britain." },
        new() { ClassName = "SR King Arthur Class (N15)", WhyteNotation = "4-6-0", Designer = "Richard Maunsell", PrimaryBuilder = "Eastleigh Works", BuildDate = "1918–1927", TotalProduced = 74, Description = "Express passenger 4-6-0s developed from the Urie N15 design; named after Arthurian legends." },
        new() { ClassName = "SR N Class", WhyteNotation = "2-6-0", Designer = "Richard Maunsell", PrimaryBuilder = "Ashford Works", BuildDate = "1917–1934", TotalProduced = 80, Description = "Mixed-traffic Mogul for the Southern; many used on both passenger and goods services." },
        new() { ClassName = "SR U Class", WhyteNotation = "2-6-0", Designer = "Richard Maunsell", PrimaryBuilder = "Brighton Works", BuildDate = "1928–1931", TotalProduced = 50, Description = "Mixed-traffic Moguls rebuilt from the failed 'River' class 2-6-4T locomotives." },
        new() { ClassName = "SR Z Class", WhyteNotation = "0-8-0T", Designer = "Richard Maunsell", PrimaryBuilder = "Brighton Works", BuildDate = "1929", TotalProduced = 8, Description = "Heavy shunting tank engines for hump shunting at Southampton and Exeter yards." },

        // ── Henry Fowler (LMS) ────────────────────────────────────────────────────
        new() { ClassName = "LMS Royal Scot Class", WhyteNotation = "4-6-0", Designer = "Henry Fowler", PrimaryBuilder = "North British Locomotive Co", BuildDate = "1927–1930", TotalProduced = 70, Description = "Express passenger three-cylinder engines for the West Coast Main Line; later rebuilt by Stanier." },
        new() { ClassName = "LMS Patriot Class", WhyteNotation = "4-6-0", Designer = "Henry Fowler", PrimaryBuilder = "Crewe Works", BuildDate = "1930–1934", TotalProduced = 52, Description = "Three-cylinder express engines built on rebuilt Claughton frames; some later rebuilt as 'Baby Scots'." },
        new() { ClassName = "LMS Class 4F", WhyteNotation = "0-6-0", Designer = "Henry Fowler", PrimaryBuilder = "Derby Works", BuildDate = "1924–1941", TotalProduced = 580, Description = "The standard LMS freight 0-6-0; a development of the Midland Railway Class 4F." },
        new() { ClassName = "LMS Class 7F", WhyteNotation = "0-8-0", Designer = "Henry Fowler", PrimaryBuilder = "Crewe Works", BuildDate = "1929–1932", TotalProduced = 175, Description = "Heavy freight eight-coupled engines for mineral traffic." },

        // ── Arthur Peppercorn (LNER / BR) ─────────────────────────────────────────
        new() { ClassName = "LNER/BR Class A1", WhyteNotation = "4-6-2", Designer = "Arthur Peppercorn", PrimaryBuilder = "A1 Steam Locomotive Trust", BuildDate = "1948–1949", TotalProduced = 49, Description = "The last and most powerful LNER Pacifics; Tornado (60163) was the first new steam locomotive built in Britain since 1960.", CollectionKey = "Peppercorn Class A1" },
        new() { ClassName = "LNER Class A2", WhyteNotation = "4-6-2", Designer = "Arthur Peppercorn", PrimaryBuilder = "Doncaster Works", BuildDate = "1947–1948", TotalProduced = 15, Description = "Mixed-traffic Pacifics; one survivor, Blue Peter, is preserved." },
        new() { ClassName = "LNER Class K1", WhyteNotation = "2-6-0", Designer = "Arthur Peppercorn", PrimaryBuilder = "North British Locomotive Co", BuildDate = "1949–1950", TotalProduced = 70, Description = "Freight and mixed-traffic Moguls for the North Eastern and Scottish regions." },

        // ── Edward Thompson (LNER) ────────────────────────────────────────────────
        new() { ClassName = "LNER Class B1", WhyteNotation = "4-6-0", Designer = "Edward Thompson", PrimaryBuilder = "Gorton Works", BuildDate = "1942–1952", TotalProduced = 410, Description = "Mixed-traffic two-cylinder 4-6-0; the most numerous LNER tender locomotive class.", CollectionKey = "LNER Thompson Class B1" },
        new() { ClassName = "LNER Class L1", WhyteNotation = "2-6-4T", Designer = "Edward Thompson", PrimaryBuilder = "Darlington Works", BuildDate = "1945–1950", TotalProduced = 100, Description = "Large suburban passenger tank engines for the LNER suburban services." },

        // ── Robert Urie (LSWR) ────────────────────────────────────────────────────
        new() { ClassName = "LSWR H15 Class", WhyteNotation = "4-6-0", Designer = "Robert Urie", PrimaryBuilder = "Eastleigh Works", BuildDate = "1914–1925", TotalProduced = 26, Description = "Mixed-traffic 4-6-0 development; a forerunner of the N15 and S15 classes." },
        new() { ClassName = "LSWR N15 King Arthur Class", WhyteNotation = "4-6-0", Designer = "Robert Urie", PrimaryBuilder = "Eastleigh Works", BuildDate = "1918–1927", TotalProduced = 74, Description = "Express passenger 4-6-0s designed by Urie and continued and named by Maunsell." },
        new() { ClassName = "LSWR/SR S15 Class", WhyteNotation = "4-6-0", Designer = "Robert Urie", PrimaryBuilder = "Eastleigh Works", BuildDate = "1920–1936", TotalProduced = 45, Description = "Freight and mixed-traffic 4-6-0s; Urie built the first batch, Maunsell continued the design.", CollectionKey = "LMS Urie Class S15" },
        new() { ClassName = "LSWR G16 Class", WhyteNotation = "4-8-0T", Designer = "Robert Urie", PrimaryBuilder = "Eastleigh Works", BuildDate = "1921", TotalProduced = 4, Description = "Heavy shunting and transfer freight tank engines for the Feltham marshalling yard." },

        // ── John G. Robinson (GCR) ────────────────────────────────────────────────
        new() { ClassName = "GCR Director Class (D11)", WhyteNotation = "4-4-0", Designer = "John G. Robinson", PrimaryBuilder = "GCR Gorton Works", BuildDate = "1913–1922", TotalProduced = 45, Description = "Named express passenger 4-4-0s; the 'Improved Directors' later worked the Great Central main line.", CollectionKey = "Director Class" },
        new() { ClassName = "GCR O4 / ROD Class", WhyteNotation = "2-8-0", Designer = "John G. Robinson", PrimaryBuilder = "GCR Gorton Works", BuildDate = "1911–1921", TotalProduced = 521, Description = "Heavy freight 2-8-0; the Railway Operating Division (ROD) used hundreds in World War One." },
        new() { ClassName = "GCR A5 Class", WhyteNotation = "4-6-2T", Designer = "John G. Robinson", PrimaryBuilder = "GCR Gorton Works", BuildDate = "1911–1923", TotalProduced = 47, Description = "Suburban passenger tank engines for GCR London services from Marylebone." },

        // ── John Aspinall (L&YR) ──────────────────────────────────────────────────
        new() { ClassName = "L&YR Class 27", WhyteNotation = "0-6-0", Designer = "John Aspinall", PrimaryBuilder = "Horwich Works", BuildDate = "1889–1918", TotalProduced = 484, Description = "The standard Lancashire and Yorkshire Railway freight engine; simple, powerful, and long-lived.", CollectionKey = "L&YR Class 27" },
        new() { ClassName = "L&YR Radial Tank", WhyteNotation = "2-4-2T", Designer = "John Aspinall", PrimaryBuilder = "Horwich Works", BuildDate = "1889–1911", TotalProduced = 330, Description = "Light suburban passenger tank engines for the L&YR network." },
        new() { ClassName = "L&YR Atlantic", WhyteNotation = "4-4-2", Designer = "John Aspinall", PrimaryBuilder = "Horwich Works", BuildDate = "1899–1902", TotalProduced = 40, Description = "Express passenger Atlantics; some of the first large-boilered British express locomotives." },

        // ── F. W. Webb (LNWR) ─────────────────────────────────────────────────────
        new() { ClassName = "LNWR Coal Tank", WhyteNotation = "0-6-2T", Designer = "F. W. Webb", PrimaryBuilder = "LNWR Crewe Works", BuildDate = "1881–1897", TotalProduced = 300, Description = "Mixed-traffic tank engines; a side-tank version of Webb's standard 17-inch Coal Engine.", CollectionKey = "Webb Coal Tank (LNWR)" },
        new() { ClassName = "LNWR Precedent Class (Jumbo)", WhyteNotation = "2-4-0", Designer = "F. W. Webb", PrimaryBuilder = "LNWR Crewe Works", BuildDate = "1874–1882", TotalProduced = 166, Description = "Victorian express passenger locomotives; Hardwicke survives preserved at the NRM." },
        new() { ClassName = "LNWR Cauliflower Class", WhyteNotation = "0-6-0", Designer = "F. W. Webb", PrimaryBuilder = "LNWR Crewe Works", BuildDate = "1880–1902", TotalProduced = 310, Description = "Standard LNWR medium freight engine, named 'Cauliflower' from the LNWR crest on the splasher." },

        // ── H. G. Ivatt (LMS) ────────────────────────────────────────────────────
        new() { ClassName = "LMS Ivatt Class 2 2-6-0", WhyteNotation = "2-6-0", Designer = "H. G. Ivatt", PrimaryBuilder = "Crewe Works", BuildDate = "1946–1953", TotalProduced = 128, Description = "Light mixed-traffic tender engines; forerunner of the BR Standard Class 2 design.", CollectionKey = "LMS Ivatt Class 2 2-6-0" },
        new() { ClassName = "LMS Ivatt Class 2 Tank", WhyteNotation = "2-6-2T", Designer = "H. G. Ivatt", PrimaryBuilder = "Crewe Works", BuildDate = "1946–1952", TotalProduced = 130, Description = "Light branch line and suburban passenger tank engines.", CollectionKey = "LMS Ivatt Class 2 Tank" },
        new() { ClassName = "LMS Ivatt Class 4 Mogul", WhyteNotation = "2-6-0", Designer = "H. G. Ivatt", PrimaryBuilder = "Horwich Works", BuildDate = "1947–1948", TotalProduced = 15, Description = "Larger mixed-traffic Moguls; the design concept later developed into the BR Standard Class 4MT." },

        // ── George Hughes (LMS) ───────────────────────────────────────────────────
        new() { ClassName = "LMS Hughes Crab", WhyteNotation = "2-6-0", Designer = "George Hughes", PrimaryBuilder = "Crewe Works", BuildDate = "1926–1932", TotalProduced = 245, Description = "The 'Crab' Mogul, named for its distinctive inclined cylinders; a powerful mixed-traffic engine." },

        // ── Wilson Worsdell (NER) ─────────────────────────────────────────────────
        new() { ClassName = "NER Class P3 (LNER J27)", WhyteNotation = "0-6-0", Designer = "Wilson Worsdell", PrimaryBuilder = "Darlington Works", BuildDate = "1906–1923", TotalProduced = 115, Description = "Standard NER freight 0-6-0; worked colliery and goods trains across north-east England.", CollectionKey = "LNER J27, NER Class P3" },
        new() { ClassName = "NER Class P1 (LNER J21)", WhyteNotation = "0-6-0", Designer = "Wilson Worsdell", PrimaryBuilder = "Darlington Works", BuildDate = "1886–1895", TotalProduced = 201, Description = "An earlier NER freight 0-6-0, many lasting into BR ownership." },

        // ── John McIntosh (Caledonian Railway) ────────────────────────────────────
        new() { ClassName = "Caledonian Railway 439 Class", WhyteNotation = "0-4-4T", Designer = "John McIntosh", PrimaryBuilder = "St Rollox Works", BuildDate = "1900–1922", TotalProduced = 92, Description = "Push-pull fitted suburban and branch line tank engines for the Caledonian Railway.", CollectionKey = "Caledonian Railway Class 439" },
        new() { ClassName = "Caledonian Dunalastair IV", WhyteNotation = "4-4-0", Designer = "John McIntosh", PrimaryBuilder = "St Rollox Works", BuildDate = "1904–1910", TotalProduced = 22, Description = "The peak of McIntosh's Dunalastair express 4-4-0 development for Caledonian main lines." },

        // ── War Department / Hunslet Engine Company ───────────────────────────────
        new() { ClassName = "WD Austerity (LNER J94)", WhyteNotation = "0-6-0ST", Designer = "Hunslet Engine Company", PrimaryBuilder = "Hunslet Engine Company", BuildDate = "1943–1946", TotalProduced = 75, Description = "Wartime saddle tanks acquired by the LNER and later BR; widely used for dock and industrial shunting.", CollectionKey = "LNER J94" },
    };

    // Comprehensive ordered list of every Whyte wheel arrangement used on UK steam locomotives.
    // Format: (Notation, CommonName) — CommonName is empty when no widely-used name exists.
    public static readonly IReadOnlyList<(string Notation, string CommonName)> AllWheelArrangements =
        new List<(string, string)>
    {
        // ── Early / single-driver tender ──────────────────────────────────────────
        ("2-2-2",   "Single"),
        ("4-2-2",   "Single Driver"),
        // ── Small tender ──────────────────────────────────────────────────────────
        ("2-4-0",   ""),
        ("4-4-0",   ""),
        ("4-4-2",   "Atlantic"),
        // ── Six-coupled tender ────────────────────────────────────────────────────
        ("0-6-0",   ""),
        ("2-6-0",   "Mogul"),
        ("4-6-0",   ""),
        ("2-6-2",   "Prairie"),
        ("4-6-2",   "Pacific"),
        // ── Eight-coupled tender ──────────────────────────────────────────────────
        ("0-8-0",   ""),
        ("2-8-0",   "Consolidation"),
        ("4-8-0",   ""),
        ("2-8-2",   "Mikado"),
        // ── Ten-coupled tender ────────────────────────────────────────────────────
        ("0-10-0",  "Decapod"),
        ("2-10-0",  ""),
        // ── Small tanks ───────────────────────────────────────────────────────────
        ("0-4-0T",  ""),
        ("0-4-0ST", "Saddle Tank"),
        ("0-4-2T",  ""),
        ("0-4-4T",  ""),
        ("2-4-0T",  ""),
        ("2-4-2T",  ""),
        ("4-4-0T",  ""),
        ("4-4-2T",  ""),
        // ── Six-coupled tanks ─────────────────────────────────────────────────────
        ("0-6-0T",  ""),
        ("0-6-0ST", "Saddle Tank"),
        ("0-6-0PT", "Pannier Tank"),
        ("0-6-2T",  ""),
        ("0-6-4T",  ""),
        ("2-6-0T",  ""),
        ("2-6-2T",  "Prairie Tank"),
        ("2-6-4T",  ""),
        ("4-6-0T",  ""),
        ("4-6-2T",  ""),
        ("4-6-4T",  ""),
        // ── Eight-coupled tanks ───────────────────────────────────────────────────
        ("0-8-0T",  ""),
        ("2-8-0T",  ""),
        ("2-8-2T",  ""),
        ("4-8-0T",  ""),
        // ── Special / articulated ─────────────────────────────────────────────────
        ("0-6-6-0T",""),
    };

    public static readonly IReadOnlyDictionary<string, string> BuilderDescriptions = new Dictionary<string, string>
    {
        ["Doncaster Works"] = "Doncaster Works (known as 'The Plant') was the principal works of the Great Northern Railway and later the LNER. It built and maintained many famous locomotives including Mallard (4468) and Flying Scotsman (4472).",
        ["Darlington Works"] = "Darlington Works was the main locomotive works of the North Eastern Railway and later the LNER. It constructed numerous NER and LNER designs, including many Gresley K3 and K4 Moguls.",
        ["Crewe Works"] = "Crewe Works was the principal locomotive works of the London and North Western Railway and later the LMS. One of the largest railway workshops in the world, it built thousands of locomotives over its long history.",
        ["Derby Works"] = "Derby Works was the main locomotive works of the Midland Railway and then the LMS. It produced numerous Midland and LMS designs including the Stanier 2-6-4T and 2-6-2T tank engines.",
        ["Swindon Works"] = "Swindon Works was the headquarters of the Great Western Railway's engineering operation. Under Churchward and Collett it produced a comprehensive and distinctive range of locomotives that dominated GWR motive power for decades.",
        ["GWR Swindon Works"] = "GWR Swindon Works was the headquarters of the Great Western Railway's engineering operation. Under Churchward and Collett it produced a comprehensive and distinctive range of locomotives that dominated GWR motive power for decades.",
        ["Brighton Works"] = "Brighton Works was the principal works of the London, Brighton and South Coast Railway and later the Southern Railway. Under Bulleid it built the West Country and Battle of Britain Pacifics.",
        ["Eastleigh Works"] = "Eastleigh Works replaced Nine Elms as the principal locomotive works of the London and South Western Railway. Under Urie and Maunsell it built and maintained many Southern Region steam classes.",
        ["North British Locomotive Co"] = "The North British Locomotive Company, based in Glasgow, was the largest locomotive manufacturer in Europe in the early twentieth century. It built many LNER, LMS, and British Railways locomotives, including the LMS Royal Scot class.",
        ["Horwich Works"] = "Horwich Works was the principal works of the Lancashire and Yorkshire Railway, opened in 1889. Under Aspinall it built hundreds of L&YR locomotives including the Class 27 0-6-0 freight engines.",
        ["GCR Gorton Works"] = "Gorton Works (Manchester) was the principal works of the Great Central Railway. Under Robinson it produced notable designs including the Director class 4-4-0 and the O4 2-8-0 heavy freight engines.",
        ["Ashford Works"] = "Ashford Works was the principal works of the South Eastern and Chatham Railway. It built and maintained Southern Railway locomotives under Maunsell, including the N Class Moguls.",
        ["LNWR Crewe Works"] = "LNWR Crewe Works (as distinct from the later LMS/BR Crewe Works) was one of the largest railway workshops in Victorian Britain. Under Webb it produced hundreds of coal tanks, cauliflowers, and express passenger engines.",
        ["St Rollox Works"] = "St Rollox Works (Glasgow) was the principal locomotive works of the Caledonian Railway. Under McIntosh it produced the Dunalastair express 4-4-0s and the 439 class suburban tank engines.",
        ["Hunslet Engine Company"] = "Hunslet Engine Company (Leeds, founded 1864) was a major manufacturer of industrial, colliery, and military locomotives. Their WD Austerity 0-6-0ST was produced in large numbers for the War Department and later used by the LNER and other operators.",
        ["A1 Steam Locomotive Trust"] = "The A1 Steam Locomotive Trust was founded in 1990 to construct a new Peppercorn A1 Pacific. Tornado (60163) was completed at Darlington in 2008 — the first new main-line steam locomotive built in Britain since 1960.",
    };

    public static readonly IReadOnlyDictionary<string, string> DesignerBios = new Dictionary<string, string>
    {
        ["Nigel Gresley"] = "Sir Herbert Nigel Gresley (1876–1941) was Chief Mechanical Engineer of the Great Northern Railway and later the London and North Eastern Railway. He is renowned for the streamlined A4 Pacifics — including Mallard, which holds the world steam speed record of 126 mph — as well as the iconic A3 Flying Scotsman and the powerful V2 mixed-traffic class.",
        ["William Stanier"] = "Sir William Arthur Stanier (1876–1965) became Chief Mechanical Engineer of the London Midland and Scottish Railway in 1932. Influenced by Great Western Railway practice, he transformed LMS motive power with designs including the legendary Black Five, the 8F freight engine, and the streamlined Coronation Pacifics.",
        ["Robert Riddles"] = "Robert Arthur Riddles (1892–1983) was the Railway Executive's Member for Mechanical and Electrical Engineering from 1948. He oversaw the design of the British Railways Standard classes — eleven classes of modern steam locomotives introduced from 1951 — including the powerful 9F 2-10-0 and the Britannia Pacifics.",
        ["Charles Collett"] = "Charles Benjamin Collett (1871–1952) was Chief Mechanical Engineer of the Great Western Railway from 1921 to 1941. He developed Churchward's sound engineering foundations into a comprehensive range of locomotive classes including the Castle, King, Hall, and the ubiquitous 5700 Pannier Tank.",
        ["George Jackson Churchward"] = "George Jackson Churchward (1857–1933) was Chief Mechanical Engineer of the Great Western Railway from 1902 to 1921. He transformed British locomotive engineering by studying American and Continental best practice, introducing standardised boiler design, long-travel valve gear, and high-degree superheating — principles that influenced a generation of designers.",
        ["Oliver Bulleid"] = "Oliver Vaughan Snell Bulleid (1882–1970) was Chief Mechanical Engineer of the Southern Railway from 1937. An unconventional innovator, he produced the air-smoothed Merchant Navy and West Country Pacifics with chain-driven valve gear, and the radical Leader class. Many of his Pacifics were later rebuilt to a conventional form by BR.",
        ["Richard Maunsell"] = "Richard Edward Lloyd Maunsell (1868–1944) was Chief Mechanical Engineer of the South Eastern and Chatham Railway and then the Southern Railway from 1913 to 1937. A pragmatic engineer, he produced successful classes including the Schools 4-4-0 — the most powerful 4-4-0 ever built in Britain — and continued developing Urie's freight designs.",
        ["Henry Fowler"] = "Sir Henry Fowler (1870–1938) was Chief Mechanical Engineer of the Midland Railway and then the LMS from 1909 to 1931. He continued Midland Railway principles on the LMS, producing the Royal Scot and Patriot express passenger classes and the very numerous Class 4F freight 0-6-0.",
        ["Arthur Peppercorn"] = "Arthur Henry Peppercorn (1889–1951) was the last Chief Mechanical Engineer of the London and North Eastern Railway. His A1 and A2 Pacific classes were among the finest express locomotives in Britain; the A1 design was later revived by the A1 Steam Locomotive Trust to construct Tornado (60163), the first new main-line steam locomotive built in Britain since 1960.",
        ["Edward Thompson"] = "Edward Thompson (1881–1954) was Chief Mechanical Engineer of the LNER from 1941 to 1946. He introduced the highly successful B1 mixed-traffic 4-6-0 and rebuilt several Gresley classes, sometimes controversially. His rebuilds of Gresley's three-cylinder designs to two-cylinder form were seen as necessary simplification for wartime maintenance.",
        ["Robert Urie"] = "Robert Wallace Urie (1854–1937) was Chief Mechanical Engineer of the London and South Western Railway from 1912 to 1922. He introduced modern locomotive practice to the LSWR with the H15, N15 (King Arthur), and S15 classes — all of which were continued and developed by his successor, Richard Maunsell, on the Southern Railway.",
        ["John G. Robinson"] = "John George Robinson (1856–1943) was Chief Mechanical Engineer of the Great Central Railway from 1900 to 1922. His finest designs included the elegant Director 4-4-0 passenger engines and the O4 heavy freight 2-8-0, of which many hundreds were built for the Railway Operating Division in World War One.",
        ["John Aspinall"] = "Sir John Audley Frederick Aspinall (1851–1937) was Chief Mechanical Engineer of the Lancashire and Yorkshire Railway from 1886 to 1899. His Class 27 0-6-0 freight engines numbered 484 and were among the most numerous single classes built by any pre-Grouping railway company.",
        ["F. W. Webb"] = "Francis William Webb (1836–1906) was Chief Mechanical Engineer of the London and North Western Railway from 1871 to 1903. He was prolific but sometimes controversial; his compound locomotive experiments were largely unsuccessful, but his Coal Tank and Cauliflower 0-6-0 classes were practical and numerous.",
        ["H. G. Ivatt"] = "Henry George Ivatt (1886–1972) was Chief Mechanical Engineer of the LMS from 1945 to 1947. His Class 2 2-6-0 and 2-6-2T designs introduced modern lightweight construction and easy maintenance features that directly influenced the BR Standard classes designed by his successor Robert Riddles.",
        ["George Hughes"] = "George Hughes (1865–1945) was Chief Mechanical Engineer of the Lancashire and Yorkshire Railway and then the LMS from 1921 to 1925. His most notable design was the 'Crab' 2-6-0 mixed-traffic Mogul, recognisable by its steeply inclined cylinders.",
        ["Wilson Worsdell"] = "Thomas William Worsdell (1838–1916) and his brother Wilson Worsdell (1850–1920) were successive Chief Mechanical Engineers of the North Eastern Railway. Wilson's Class P3 (LNER J27) freight 0-6-0 was one of the most successful pre-Grouping freight designs, with examples lasting into the 1960s.",
        ["John McIntosh"] = "John Farquharson McIntosh (1846–1918) was Locomotive Superintendent of the Caledonian Railway from 1895 to 1914. His Dunalastair series of express 4-4-0s was influential across Europe, and his 439 Class 0-4-4T tanks were the last steam locomotives to work in everyday BR passenger service (until 1962).",
        ["Hunslet Engine Company"] = "The Hunslet Engine Company (founded 1864) was a Leeds-based locomotive manufacturer that produced industrial, colliery, and military locomotives. Their WD Austerity 0-6-0ST design was built in large numbers for the War Department during World War Two and many were later acquired by the LNER and other operators.",
        ["John Ramsbottom"] = "John Ramsbottom (1814–1897) was Locomotive Superintendent of the London and North Western Railway from 1857 to 1871. He invented the Ramsbottom safety valve and the water trough (allowing locomotives to pick up water without stopping), and his DX Goods 0-6-0 became one of the most numerous classes of the Victorian era with over 940 built.",
        ["Patrick Stirling"] = "Patrick Stirling (1820–1895) was Locomotive Superintendent of the Great Northern Railway from 1866 until his death in 1895. He is best known for his graceful 8-foot Single 4-2-2 express locomotives, particularly No. 1, which regularly hauled the Flying Scotsman express and survives preserved at the National Railway Museum.",
        ["David Jones"] = "David Jones (1834–1906) was Locomotive Superintendent of the Highland Railway from 1870 to 1896. He is notable for designing the Jones Goods 4-6-0 in 1894 — the first 4-6-0 type locomotive to run in Britain — breaking new ground with a wheel arrangement that would later be adopted by virtually every major British railway.",
        ["William Stroudley"] = "William Stroudley (1833–1889) was Locomotive Superintendent of the London, Brighton and South Coast Railway from 1870 until his death in 1889. He imposed strict standardisation and introduced the distinctive Stroudley yellow ochre livery. His most celebrated design is the diminutive Terrier 0-6-0T, several of which remain in active preservation today.",
        ["Samuel Johnson"] = "Samuel Waite Johnson (1831–1912) was Locomotive Superintendent of the Midland Railway from 1873 to 1903. He produced the elegant 'Midland Spinner' single-driver 4-2-2s and a series of refined 4-4-0 passenger engines. He also continued developing the Midland's distinctive aesthetic of beautifully proportioned, Crimson Lake–painted locomotives.",
        ["William Dean"] = "William Dean (1840–1905) was Locomotive Superintendent of the Great Western Railway from 1877 to 1902. His reign bridged the Victorian and modern eras of GWR locomotive design. His later 4-4-0 locomotives pointed toward the Saint and Star classes, and he mentored George Jackson Churchward, who would revolutionise British locomotive engineering.",
        ["William Adams"] = "William Adams (1823–1904) was Locomotive Superintendent of the London and South Western Railway from 1878 to 1895. He designed capable and reliable 4-4-0 express and 0-4-2 tank engines, and introduced the Adams Radial axle which improved stability at speed. Several of his radial tank locomotives survived in industrial service into the 1960s.",
        ["James Stirling"] = "James Stirling (1835–1917) was Locomotive Superintendent of the South Eastern Railway from 1878 to 1898, and brother of Patrick Stirling. He designed the '0' class 0-6-0 freight engines and 'F' class 4-4-0 express locomotives that formed the backbone of SER motive power through the end of the nineteenth century.",
        ["T. W. Worsdell"] = "Thomas William Worsdell (1838–1916) was Locomotive Superintendent of the North Eastern Railway from 1885 to 1890. He experimented with two-cylinder compound locomotives and introduced several useful classes before handing over to his brother Wilson Worsdell. His Class C (later LNER J21) 0-6-0 was widely used for NER freight work.",
        ["James Holden"] = "James Holden (1837–1925) was Locomotive Superintendent of the Great Eastern Railway from 1885 to 1907. He designed the handsome 'Claud Hamilton' 4-4-0 express locomotives and, most famously, proved in 1891 that a Great Eastern 2-4-0 could outrun a horse-drawn tram — a publicity triumph for the railway.",
        ["R. J. Billinton"] = "Robert John Billinton (1845–1904) was Locomotive Superintendent of the London, Brighton and South Coast Railway from 1890 to 1904. He succeeded Stroudley and replaced the yellow ochre livery with dark brown. His B2 and B4 4-4-0 classes were competent express engines for LBSCR coastal and London services.",
        ["Dugald Drummond"] = "Dugald Drummond (1840–1912) was Locomotive Superintendent of the London and South Western Railway from 1895 to 1912. His T9 'Greyhound' 4-4-0s were among the most elegant and successful express locomotives of the Edwardian era, earning a reputation for sustained high-speed running on LSWR expresses to Bournemouth and Exeter.",
        ["H. A. Ivatt"] = "Henry Alfred Ivatt (1851–1923) was Locomotive Superintendent of the Great Northern Railway from 1896 to 1911 and father of H. G. Ivatt. He introduced the Atlantic (4-4-2) type to Britain, initially as small-boilered engines (C1) and then the very successful large-boilered 'Klondike' Atlantics that dominated GNR express work for two decades.",
        ["Harry Wainwright"] = "Harry Smith Wainwright (1864–1925) was Locomotive Superintendent of the South Eastern & Chatham Railway from 1899 to 1913. His D and E class 4-4-0 locomotives were striking machines in the SECR's distinctive green livery, and were considered handsome even by the standards of the Edwardian locomotive renaissance.",
        ["Richard Deeley"] = "Richard Mountford Deeley (1855–1944) was Chief Mechanical Engineer of the Midland Railway from 1904 to 1909. His tenure was brief but he succeeded in simplifying Johnson's compound locomotive design into the reliable Midland Compound 4-4-0, of which Fowler later built further batches for the LMS. 45 MR Compounds passed into LMS ownership.",
        ["F. W. Hawksworth"] = "Frederick William Hawksworth (1884–1976) was Chief Mechanical Engineer of the Great Western Railway from 1941 to 1947. He presided over wartime conditions with pragmatism, producing the Modified Hall and the County class 4-6-0 — the latter being the most powerful two-cylinder express engine the GWR ever built — before nationalisation ended independent GWR locomotive design.",
    };

    // Supplementary descriptions for arrangements not already covered by WheelArrangementDescriptions.
    // Merged at runtime in WheelArrangementListPage.
    public static readonly IReadOnlyDictionary<string, string> ExtraWheelArrangementDescriptions =
        new Dictionary<string, string>
        {
            ["2-2-2"] = "The Single (2-2-2) was the dominant express passenger wheel arrangement of the early Victorian era. With only one pair of large driving wheels it could achieve high speeds on light trains, and was favoured by designers such as Stirling and Crampton.",
            ["4-2-2"] = "The Single Driver (4-2-2) added a four-wheeled leading bogie to the single-driver concept, giving better tracking at speed. The Great Northern Railway's Stirling Singles and the Midland Railway's Johnson Spinners used this arrangement.",
            ["2-4-0"] = "The 2-4-0 arrangement has a two-wheeled leading truck and four coupled driving wheels. Common for express and mixed-traffic work in the mid-Victorian period; the LNWR Precedent (Jumbo) class was perhaps the most famous British example.",
            ["4-4-0"] = "The 4-4-0 arrangement has a four-wheeled leading bogie and four coupled driving wheels. The dominant express passenger arrangement of the Victorian and Edwardian eras, remaining in use on secondary express duties into the 1940s.",
            ["0-6-0"] = "The 0-6-0 arrangement has six coupled driving wheels with no leading or trailing axle. The most numerous wheel arrangement in British railway history, used from the earliest days of steam for goods and mixed-traffic work on virtually every railway company.",
            ["0-8-0"] = "The 0-8-0 arrangement has eight coupled driving wheels. Used for heavy slow freight over steep gradients; the LNWR and LMS both operated large fleets for mineral traffic in the Welsh valleys and the Pennines.",
            ["4-8-0"] = "The 4-8-0 arrangement was rare on British railways. The Great Central Railway's MS&LR 4-8-0T is one of the few examples; the design offered greater adhesion than a 4-6-0 for heavy freight.",
            ["0-10-0"] = "The 0-10-0 was used in Britain primarily for the Midland Railway's Lickey Banker — 'Big Bertha' (No. 22290) — built in 1919 for banking trains up the 1-in-37 Lickey Incline in Worcestershire. It was the most powerful British steam locomotive of its day.",
            ["0-4-0T"] = "The 0-4-0 tank has four coupled driving wheels and carries its water and fuel on the locomotive itself. Used for light shunting in confined spaces such as docks, gasworks, and industrial yards where a longer wheelbase would not negotiate tight curves.",
            ["0-4-0ST"] = "The 0-4-0 saddle tank carries a curved water tank draped over the boiler like a saddle. A compact and robust shunter found at collieries, quarries, and industrial sites throughout Britain.",
            ["0-4-2T"] = "The 0-4-2 tank has four coupled drivers and a two-wheeled trailing truck for the bunker. The GWR used the 48xx (later 14xx) class 0-4-2T for auto-train working on many rural branch lines.",
            ["2-4-0T"] = "The 2-4-0 tank has a two-wheeled leading truck, four coupled drivers, and carries its own fuel and water. Used for light suburban and branch passenger services in the Victorian era.",
            ["4-4-0T"] = "The 4-4-0 tank was used for short-distance express suburban services. The Metropolitan Railway and London, Tilbury and Southend Railway both operated 4-4-0T locomotives for their demanding commuter traffic.",
            ["4-4-2T"] = "The 4-4-2 tank, with a four-wheeled leading bogie, four coupled drivers, and a two-wheeled trailing truck, was used for fast suburban services. The London, Brighton and South Coast Railway's I3 class was a well-known example.",
            ["0-6-4T"] = "The 0-6-4 tank arrangement, with a trailing four-wheeled bogie, was occasionally used on suburban passenger work. The Midland Railway built some examples for London St Pancras suburban services.",
            ["2-6-0T"] = "The 2-6-0 tank (Mogul tank) has a two-wheeled leading truck, six coupled drivers, and carries its own water and fuel. The GWR 4200 and 5200 classes used a 2-8-0T variant; some pure 2-6-0Ts also appeared on South Wales mineral traffic.",
            ["4-6-0T"] = "The 4-6-0 tank has a four-wheeled leading bogie and six coupled driving wheels. The London, Tilbury and Southend Railway 4-6-4T and some Highland Railway engines used this arrangement for passenger services.",
            ["4-6-4T"] = "The 4-6-4 tank (Baltic) has a four-wheeled leading bogie, six coupled driving wheels, and a four-wheeled trailing bogie. Used by the LMS and its predecessors for fast suburban work, including the Tilbury line 4-6-4Ts rebuilt from 4-6-2Ts.",
            ["2-8-0T"] = "The 2-8-0 tank arrangement was used primarily by the Great Western Railway for heavy South Wales coal traffic. The GWR 4200 class (later 5200) operated on steep valley lines where high adhesion was essential.",
            ["2-8-2T"] = "The 2-8-2 tank (Mikado tank) offers the adhesion of eight coupled wheels with a large bunker behind the cab. The GWR 7200 class, rebuilt from 2-8-0T locomotives, operated on heavy South Wales mineral trains.",
            ["4-8-0T"] = "The 4-8-0 tank has a four-wheeled leading bogie and eight coupled driving wheels. In Britain it appeared on Urie's LSWR G16 class, built for heavy transfer freight work at the Feltham marshalling yard.",
        };

    // Hex colours keyed by RailwayCode — chosen to reflect each company's historic livery
    public static readonly IReadOnlyDictionary<string, string> RailwayColors = new Dictionary<string, string>
    {
        ["GNR"] = "#3d7a3d",  // GNR apple green
        ["GWR"] = "#005c2e",  // GWR Brunswick green
        ["LNER"] = "#509b2a",  // LNER apple green
        ["LMS"] = "#8b0000",  // LMS crimson lake
        ["SR"] = "#007d3e",  // SR malachite green
        ["LBSCR"] = "#c8a428",  // LBSCR umber/ochre
        ["LSWR"] = "#6b8c42",  // LSWR sage green
        ["MR"] = "#c0003c",  // Midland Railway crimson red
        ["LNWR"] = "#2d2d2d",  // LNWR black
        ["NER"] = "#4a6741",  // NER olive green
        ["GCR"] = "#7b3300",  // GCR chocolate/maroon
        ["GER"] = "#1a4d8f",  // GER royal blue
        ["LYR"] = "#555555",  // L&YR dark grey
        ["HR"] = "#8b7d4e",  // Highland Railway olive
        ["CR"] = "#003087",  // Caledonian blue
        ["SECR"] = "#9b8b58",  // SECR bronze/olive
        ["SER"] = "#9b8b58",  // SER (same as SECR)
        ["BR"] = "#1a3a6b",  // British Railways dark blue
    };

    public static readonly IReadOnlyDictionary<string, string> WheelArrangementDescriptions = new Dictionary<string, string>
    {
        ["4-6-2"] = "The Pacific arrangement (4-6-2) features a four-wheeled leading bogie, six coupled driving wheels, and a two-wheeled trailing truck supporting a large firebox. It became the dominant express passenger wheel arrangement in Britain from the 1920s and produced some of the most celebrated steam locomotives ever built.",
        ["4-6-0"] = "The 4-6-0 arrangement has a four-wheeled leading bogie and six coupled driving wheels with no trailing axle. It was one of the most versatile British wheel arrangements, used for express passenger work (Castle, King, Black Five) as well as mixed-traffic and freight duties.",
        ["2-10-0"] = "The 2-10-0 arrangement has a two-wheeled leading truck, ten coupled driving wheels, and no trailing axle. In Britain it was most famously used for the BR Standard Class 9F — the most powerful Standard class — which proved capable of express passenger work despite being designed for heavy freight.",
        ["2-8-0"] = "The 2-8-0 arrangement (Consolidation) has a two-wheeled leading truck and eight coupled driving wheels. It was the standard British heavy freight wheel arrangement, used extensively by the GWR 28xx, LMS 8F, LNER O4, and WD Austerity classes.",
        ["2-8-2"] = "The 2-8-2 arrangement (Mikado) has a two-wheeled leading truck, eight coupled driving wheels, and a two-wheeled trailing truck. In Britain it appeared on Gresley's powerful P2 class, built for the demanding Edinburgh to Aberdeen route.",
        ["2-6-2"] = "The 2-6-2 arrangement (Prairie) has a two-wheeled leading truck, six coupled driving wheels, and a two-wheeled trailing truck. Used for both tender and tank locomotives, it appears on Gresley's V2 mixed-traffic class and numerous GWR Prairie tanks.",
        ["2-6-4T"] = "The 2-6-4 tank arrangement has a two-wheeled leading truck, six coupled driving wheels, and a four-wheeled trailing bogie carrying the coal bunker. Widely used for suburban and semi-fast passenger services, especially by the LMS Stanier and BR Standard designs.",
        ["2-6-2T"] = "The 2-6-2 tank (Prairie tank) has a two-wheeled leading truck, six coupled driving wheels, and a two-wheeled trailing truck. Used for light branch line and suburban passenger services; the GWR Prairie tanks and Ivatt/BR Standard light tanks all used this arrangement.",
        ["2-6-0"] = "The 2-6-0 arrangement (Mogul) has a two-wheeled leading truck and six coupled driving wheels. A versatile mixed-traffic arrangement used on many well-known designs including the GWR 43xx, LMS Crab, and numerous BR Standard classes.",
        ["4-4-2"] = "The 4-4-2 arrangement (Atlantic) has a four-wheeled leading bogie, four coupled driving wheels, and a two-wheeled trailing truck. Popular in the early twentieth century for express passenger work, it was used by several pre-Grouping railways including the L&YR and Great Northern Railway.",
        ["4-4-0"] = "The 4-4-0 arrangement has a four-wheeled leading bogie and four coupled driving wheels. The dominant express passenger arrangement of the Victorian and Edwardian eras, it lingered into the 1930s on secondary express duties; the SR Schools class was the most powerful 4-4-0 ever built in Britain.",
        ["0-6-2T"] = "The 0-6-2 tank arrangement has six coupled driving wheels and a two-wheeled trailing truck carrying the coal bunker. Used for suburban passenger and colliery tank locomotives; the GWR 5600 was built in large numbers for the South Wales Valleys.",
        ["0-6-0"] = "The 0-6-0 arrangement has six coupled driving wheels with no leading or trailing axle. The simplest and most numerous wheel arrangement in British history, used from the earliest days of steam through to the end of steam traction for goods and mixed-traffic work.",
        ["0-6-0T"] = "The 0-6-0 tank arrangement carries its own fuel and water without a tender. Used for shunting and short-haul trip working; the LNER J50 and BR Standard shunting tanks all used this arrangement.",
        ["0-6-0ST"] = "The 0-6-0 saddle tank carries a curved water tank over the boiler. Commonly used for industrial, colliery, and dock shunting; the WD Austerity (J94) class used this arrangement extensively in wartime and post-war service.",
        ["0-6-0PT"] = "The 0-6-0 pannier tank carries its water tanks on either side of the boiler. The arrangement was particularly associated with the Great Western Railway, whose 5700 Pannier Tank class numbered 863 engines — the most numerous class of any pre-nationalisation UK railway.",
        ["4-8-0T"] = "The 4-8-0 tank arrangement has a four-wheeled leading bogie and eight coupled driving wheels. A relatively rare arrangement in Britain, used by Urie's LSWR G16 class for heavy transfer freight work at Feltham marshalling yard.",
        ["4-6-2T"] = "The 4-6-2 tank arrangement has a four-wheeled leading bogie, six coupled driving wheels, and a two-wheeled trailing truck. Used for suburban express tank engines; the GCR A5 class worked London Marylebone suburban services.",
        ["0-8-0"] = "The 0-8-0 arrangement has eight coupled driving wheels with no leading or trailing axle. Used for slow heavy freight haulage; the LNWR 0-8-0 and LMS 7F used this arrangement for mineral and coal traffic.",
        ["0-8-0T"] = "The 0-8-0 tank arrangement carries water and coal without a separate tender. Used for heavy shunting and transfer freight in yards; the SR Z Class worked hump shunting at Southampton Docks.",
        ["0-4-4T"] = "The 0-4-4 tank arrangement has four coupled driving wheels and a four-wheeled trailing bogie. Widely used for suburban passenger services on branch lines; the Caledonian 439 class used this arrangement.",
        ["2-4-0"] = "The 2-4-0 arrangement was common in the Victorian era for express passenger work. It has a two-wheeled leading truck and four coupled driving wheels; LNWR Precedent (Jumbo) class used it into the twentieth century.",
        ["2-4-2T"] = "The 2-4-2 tank arrangement was used for light suburban and branch line passenger work. The L&YR Radial Tank class used this arrangement for many years on Lancashire routes.",
        ["0-6-6-0T"] = "The 0-6-6-0 tank arrangement was used on Bulleid's experimental Leader class. Two six-coupled bogies were coupled to allow the fireman to access either end of the locomotive; the design was highly innovative but technically troubled.",
    };
}